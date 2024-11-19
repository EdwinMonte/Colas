namespace Colas
{
    public partial class Form1 : Form
    {
        private int[] queue;
        private int front;
        private int rear;
        private int size;
        private int count;
        public Form1()
        {
            InitializeComponent();
            size = 5; // Tamaño de la cola
            queue = new int[size];
            front = 0;
            rear = -1;
            count = 0;
        }

        private void UpdateListBox()
        {
            lstQueue.Items.Clear();
            int tempFront = front;
            for (int i = 0; i < count; i++)
            {
                lstQueue.Items.Add(queue[tempFront]);
                tempFront = (tempFront + 1) % size;
            }
        }
        private void btnEnqueue_Click(object sender, EventArgs e)
        {
            if (count == size)
            {
                MessageBox.Show("Queue Overflow. Cannot enqueue more elements.");
            }
            else
            {
                if (int.TryParse(txtValue.Text, out int value))
                {
                    rear = (rear + 1) % size;
                    queue[rear] = value;
                    count++;
                    UpdateListBox();
                }
                else
                {
                    MessageBox.Show("Please enter a valid number.");
                }
            }
        }

        private void btnDequeue_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                MessageBox.Show("Queue Underflow. No elements to dequeue.");
            }
            else
            {
                MessageBox.Show($"Dequeued: {queue[front]}");
                front = (front + 1) % size;
                count--;
                UpdateListBox();
            }
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                MessageBox.Show("Queue is empty.");
            }
            else
            {
                MessageBox.Show($"Front element: {queue[front]}");
            }
        }
    }
    
}

