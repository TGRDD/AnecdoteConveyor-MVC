/// <summary>
/// Instant display mode for new windows without animations
/// </summary>
public class ForceMenuSystemView : IMenuSystemView
{
    public void UpdateView(MenuSystemViewModel viewModel)
    {
        if (viewModel.PreviousTabObject != null)
        {
            viewModel.PreviousTabObject.Hide();
        }

        viewModel.CurrentTabObject.Show();
    }
}
