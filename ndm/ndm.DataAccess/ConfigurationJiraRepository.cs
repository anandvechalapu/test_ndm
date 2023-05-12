namespace Ndm 
{
    public class ConfigurationJiraRepository
    {
        public async Task<ConfigurationJiraModel> GetConfigurationJiraModelAsync(int id)
        {
            using (var connection = new SqlConnection(""))
            {
                connection.Open();
                var parameters = new DynamicParameters();
                parameters.Add("@Id", id);
                var result = await connection.QuerySingleOrDefaultAsync<ConfigurationJiraModel>(
                        "SELECT Id, SacralWebsite, ExpertServicesPage, Configure, JiraSoftware, JiraUsername, JiraPassword, JiraURL, RepositoryName, ResetButton, SaveButton, JavaAPI, ListTitle, ListUsername, ListURL, ListAction, EditButton, DeleteButton, ShowEntries, Pagination, AddMoreButton, PopupForm FROM ConfigurationJira WHERE Id = @Id",
                        parameters);
                return result;
            }
        }

        public async Task<bool> CreateConfigurationJiraModelAsync(ConfigurationJiraModel configurationJiraModel)
        {
            using (var connection = new SqlConnection(""))
            {
                connection.Open();
                var parameters = new DynamicParameters();
                parameters.Add("@SacralWebsite", configurationJiraModel.SacralWebsite);
                parameters.Add("@ExpertServicesPage", configurationJiraModel.ExpertServicesPage);
                parameters.Add("@Configure", configurationJiraModel.Configure);
                parameters.Add("@JiraSoftware", configurationJiraModel.JiraSoftware);
                parameters.Add("@JiraUsername", configurationJiraModel.JiraUsername);
                parameters.Add("@JiraPassword", configurationJiraModel.JiraPassword);
                parameters.Add("@JiraURL", configurationJiraModel.JiraURL);
                parameters.Add("@RepositoryName", configurationJiraModel.RepositoryName);
                parameters.Add("@ResetButton", configurationJiraModel.ResetButton);
                parameters.Add("@SaveButton", configurationJiraModel.SaveButton);
                parameters.Add("@JavaAPI", configurationJiraModel.JavaAPI);
                parameters.Add("@ListTitle", configurationJiraModel.ListTitle);
                parameters.Add("@ListUsername", configurationJiraModel.ListUsername);
                parameters.Add("@ListURL", configurationJiraModel.ListURL);
                parameters.Add("@ListAction", configurationJiraModel.ListAction);
                parameters.Add("@EditButton", configurationJiraModel.EditButton);
                parameters.Add("@DeleteButton", configurationJiraModel.DeleteButton);
                parameters.Add("@ShowEntries", configurationJiraModel.ShowEntries);
                parameters.Add("@Pagination", configurationJiraModel.Pagination);
                parameters.Add("@AddMoreButton", configurationJiraModel.AddMoreButton);
                parameters.Add("@PopupForm", configurationJiraModel.PopupForm);

                var result = await connection.ExecuteAsync(
                    "INSERT INTO ConfigurationJira (SacralWebsite, ExpertServicesPage, Configure, JiraSoftware, JiraUsername, JiraPassword, JiraURL, RepositoryName, ResetButton, SaveButton, JavaAPI, ListTitle, ListUsername, ListURL, ListAction, EditButton, DeleteButton, ShowEntries, Pagination, AddMoreButton, PopupForm) " +
                    "VALUES (@SacralWebsite, @ExpertServicesPage, @Configure, @JiraSoftware, @JiraUsername, @JiraPassword, @JiraURL, @RepositoryName, @ResetButton, @SaveButton, @JavaAPI, @ListTitle, @ListUsername, @ListURL, @ListAction, @EditButton, @DeleteButton, @ShowEntries, @Pagination, @AddMoreButton, @PopupForm)",
                    parameters);
                return true;
            }
        }

        public async Task<bool> UpdateConfigurationJiraModelAsync(ConfigurationJiraModel configurationJiraModel)
        {
            using (var connection = new SqlConnection(""))
            {
                connection.Open();
                var parameters = new DynamicParameters();
                parameters.Add("@Id", configurationJiraModel.Id);
                parameters.Add("@SacralWebsite", configurationJiraModel.SacralWebsite);
                parameters.Add("@ExpertServicesPage", configurationJiraModel.ExpertServicesPage);
                parameters.Add("@Configure", configurationJira