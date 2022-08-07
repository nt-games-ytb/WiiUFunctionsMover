namespace WiiUFunctionsMover
{
    public partial class WiiUFunctionMover : Form
    {
        public WiiUFunctionMover()
        {
            InitializeComponent();
        }

        private void make_Click(object sender, EventArgs e)
        {
            uint address1 = (uint)Convert.ToInt32(baseAddressMake.Text, 16);
            uint address2 = (uint)Convert.ToInt32(destinationAddressMake.Text, 16);
            uint numberBetween = 0;
            uint result = 0;

            if (address1 < address2) //48000000
            {
                numberBetween = address2 - address1;
                result = 0x48000000 + numberBetween;
            }
            else //4C000000
            { 
                numberBetween = address1 - address2;
                result = 0x4C000000 - numberBetween;
            }

            valueMake.Text = Convert.ToString(result, 16);
        }

        private void find_Click(object sender, EventArgs e)
        {
            uint address = (uint)Convert.ToInt32(baseAddressFind.Text, 16);
            uint value = (uint)Convert.ToInt32(valueFind.Text, 16);
            uint numberBetween = 0;
            uint result = 0;

            if (valueFindLabel.Text != "Value : (Auto detect)")
            {
                if (valueFindLabel.Text == "Value : (48000000)") //48000000
                {
                    numberBetween = value - 0x48000000;
                    result = address + numberBetween;
                }
                else //4C000000
                {
                    numberBetween = 0x4C000000 - value;
                    result = address - numberBetween;
                }
            }
            else
            {
                bool good = false;
                while (good == false)
                {
                    if (valueFindLabel.Text == "Value : (48000000)") //48000000
                    {
                        numberBetween = value - 0x48000000;
                        result = address + numberBetween;

                        if (address > result)
                        {
                            good = true;
                        }
                        else
                        {
                            if (valueFindLabel.Text == "Value : (48000000)")
                            {
                                valueFindLabel.Text = "Value : (4C000000)";
                            }
                            else
                            {
                                valueFindLabel.Text = "Value : (48000000)";
                            }
                        }
                    }
                    else //4C000000
                    {
                        numberBetween = 0x4C000000 - value;
                        result = address - numberBetween;

                        if (address > result)
                        {
                            good = true;
                        }
                        else
                        {
                            if (valueFindLabel.Text == "Value : (48000000)")
                            {
                                valueFindLabel.Text = "Value : (4C000000)";
                            }
                            else
                            {
                                valueFindLabel.Text = "Value : (48000000)";
                            }
                        }
                    }
                }

                valueFindLabel.Text = "Value : (Auto detect)";
            }

            destinationAddressFind.Text = Convert.ToString(result, 16);
        }

        private void valueFindLabel_Click(object sender, EventArgs e)
        {
            if (valueFindLabel.Text == "Value : (Auto detect)")
            {
                valueFindLabel.Text = "Value : (48000000)";
            }
            else if (valueFindLabel.Text == "Value : (48000000)")
            {
                valueFindLabel.Text = "Value : (4C000000)";
            }
            else
            {
                valueFindLabel.Text = "Value : (Auto detect)";
            }
        }
    }
}