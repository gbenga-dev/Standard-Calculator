namespace Standard_Calculator.StandardCalc;

public partial class CalculatorApp : ContentPage
{
    public double valueNum1;
    public double valueNum2;
    public double calcresult;

    public Boolean flag = false;
    public CalculatorApp()
	{
		InitializeComponent();
	}
    
    private void OnNumClicked(object sender, EventArgs e)
    {
        
        Button number = (Button)sender;

        if (!lblOperator.IsVisible && string.IsNullOrEmpty(lblOperator.Text) && string.IsNullOrEmpty(entryValue2.Text))
        {
            entryValue1.IsVisible = true;
            entryValue1.Text += number.Text;
        }

        if (!lblOperator.IsVisible && string.IsNullOrEmpty(lblOperator.Text) && string.IsNullOrEmpty(entryValue2.Text) && string.IsNullOrEmpty(entryValue1.Text) && flag == true)
        {
            entryValue1.IsVisible = true;
            entryValue1.Text += number.Text;
        }

        else if (lblOperator.IsVisible && !string.IsNullOrEmpty(lblOperator.Text) && !string.IsNullOrEmpty(entryValue1.Text))
        {

            entryValue2.IsVisible = true;
            entryValue2.Text += number.Text;

        }
    }

    private void OnOperator_Clicked(object sender, EventArgs e)
    {
        
        var mathOperator = (Button)sender;
        if (!string.IsNullOrEmpty(entryValue1.Text))
        {
            lblOperator.IsVisible = true;
            lblOperator.Text += mathOperator.Text;
            entryValue1.IsVisible=true;
            lblResult.IsVisible = false;

        }

        
    }

    private void resultbtn_Clicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(entryValue1.Text) && !string.IsNullOrEmpty(entryValue2.Text))
        {
            MathOperation(lblOperator.Text);

            entryValue1.IsVisible = false;
            entryValue1.Text =lblResult.Text;
            entryValue2.IsVisible = false;
            entryValue2.Text = string.Empty;
            lblOperator.IsVisible = false;
            lblOperator.Text = string.Empty;

            flag = true;
        }

    }

    private void MathOperation(string mathOperator)
    {
        if (!string.IsNullOrEmpty(entryValue1.Text))
        {
            valueNum1 = Convert.ToDouble(entryValue1.Text);

        }
        if (!string.IsNullOrEmpty(entryValue2.Text))
        {
            valueNum2 = Convert.ToDouble(entryValue2.Text);

        }

        if ( mathOperator == "+")
        {
            calcresult = (valueNum1 + valueNum2);
            lblResult.IsVisible = true;
            lblResult.Text=calcresult.ToString();   
        }
        else if( mathOperator == "-")
        {
            calcresult = valueNum1 - valueNum2;
            lblResult.IsVisible = true;
            lblResult.Text = calcresult.ToString();
        }
        else if(mathOperator == "*")
        {
            calcresult = valueNum1 * valueNum2;
            lblResult.IsVisible = true;
            lblResult.Text = calcresult.ToString();
        }
        else if (mathOperator == "/")
        {
            calcresult = valueNum1 / valueNum2;
            lblResult.IsVisible = true;
            lblResult.Text = calcresult.ToString();
        }
    }
   
    private void clearEntryValuebtn_Clicked(object sender, EventArgs e)
    {
        entryValue1.Text = string.Empty;
        entryValue2.Text = string.Empty;
        lblOperator.Text = string.Empty;
        lblResult.Text = string.Empty;

        entryValue1.IsVisible = false;
        lblOperator.IsVisible = false;
        entryValue2.IsVisible = false;
        
    }

    private void clearEntryValuebtn_Clicked_1(object sender, EventArgs e)
    {
        if(entryValue1.IsVisible && !string.IsNullOrEmpty(entryValue1.Text) && !lblOperator.IsVisible && string.IsNullOrEmpty(lblOperator.Text))
        {
            entryValue1.Text= entryValue1.Text.Substring(0, entryValue1.Text.Length - 1);
        }
        if(entryValue1.IsVisible && !string.IsNullOrEmpty(entryValue1.Text) && lblOperator.IsVisible && !string.IsNullOrEmpty(lblOperator.Text) && entryValue2.IsVisible && !string.IsNullOrEmpty(entryValue2.Text))
        {
            entryValue2.Text = entryValue2.Text.Substring(0, entryValue2.Text.Length - 1);
        }
    }
}