// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.AI.AnomalyDetector.Samples
{
    public partial class Samples_Multivariate
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Multivariate_GetMultivariateBatchDetectionResult_GetMultivariateBatchDetectionResult()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Multivariate client = new AnomalyDetectorClient(endpoint, credential).GetMultivariateClient();

            Response response = client.GetMultivariateBatchDetectionResult(Guid.Parse("663884e6-b117-11ea-b3de-0242ac130004"), null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("resultId").ToString());
            Console.WriteLine(result.GetProperty("summary").GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("summary").GetProperty("setupInfo").GetProperty("dataSource").ToString());
            Console.WriteLine(result.GetProperty("summary").GetProperty("setupInfo").GetProperty("startTime").ToString());
            Console.WriteLine(result.GetProperty("summary").GetProperty("setupInfo").GetProperty("endTime").ToString());
            Console.WriteLine(result.GetProperty("results")[0].GetProperty("timestamp").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Multivariate_GetMultivariateBatchDetectionResult_GetMultivariateBatchDetectionResult_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Multivariate client = new AnomalyDetectorClient(endpoint, credential).GetMultivariateClient();

            Response response = await client.GetMultivariateBatchDetectionResultAsync(Guid.Parse("663884e6-b117-11ea-b3de-0242ac130004"), null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("resultId").ToString());
            Console.WriteLine(result.GetProperty("summary").GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("summary").GetProperty("setupInfo").GetProperty("dataSource").ToString());
            Console.WriteLine(result.GetProperty("summary").GetProperty("setupInfo").GetProperty("startTime").ToString());
            Console.WriteLine(result.GetProperty("summary").GetProperty("setupInfo").GetProperty("endTime").ToString());
            Console.WriteLine(result.GetProperty("results")[0].GetProperty("timestamp").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Multivariate_GetMultivariateBatchDetectionResult_GetMultivariateBatchDetectionResult_Convenience()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Multivariate client = new AnomalyDetectorClient(endpoint, credential).GetMultivariateClient();

            Response<MultivariateDetectionResult> response = client.GetMultivariateBatchDetectionResult(Guid.Parse("663884e6-b117-11ea-b3de-0242ac130004"));
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Multivariate_GetMultivariateBatchDetectionResult_GetMultivariateBatchDetectionResult_Convenience_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Multivariate client = new AnomalyDetectorClient(endpoint, credential).GetMultivariateClient();

            Response<MultivariateDetectionResult> response = await client.GetMultivariateBatchDetectionResultAsync(Guid.Parse("663884e6-b117-11ea-b3de-0242ac130004"));
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Multivariate_TrainMultivariateModel_CreateAndTrainMultivariateModel()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Multivariate client = new AnomalyDetectorClient(endpoint, credential).GetMultivariateClient();

            using RequestContent content = RequestContent.Create(new
            {
                slidingWindow = 20,
                alignPolicy = new
                {
                    alignMode = "Outer",
                    fillNAMethod = "Linear",
                    paddingValue = 0F,
                },
                dataSource = "https://multiadsample.blob.core.windows.net/data/sample_data_2_1000.csv",
                dataSchema = "OneTable",
                startTime = "2019-04-01T00:00:00Z",
                endTime = "2019-04-02T00:00:00Z",
                displayName = "Devops-MultiAD",
            });
            Response response = client.TrainMultivariateModel(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("modelId").ToString());
            Console.WriteLine(result.GetProperty("createdTime").ToString());
            Console.WriteLine(result.GetProperty("lastUpdatedTime").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Multivariate_TrainMultivariateModel_CreateAndTrainMultivariateModel_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Multivariate client = new AnomalyDetectorClient(endpoint, credential).GetMultivariateClient();

            using RequestContent content = RequestContent.Create(new
            {
                slidingWindow = 20,
                alignPolicy = new
                {
                    alignMode = "Outer",
                    fillNAMethod = "Linear",
                    paddingValue = 0F,
                },
                dataSource = "https://multiadsample.blob.core.windows.net/data/sample_data_2_1000.csv",
                dataSchema = "OneTable",
                startTime = "2019-04-01T00:00:00Z",
                endTime = "2019-04-02T00:00:00Z",
                displayName = "Devops-MultiAD",
            });
            Response response = await client.TrainMultivariateModelAsync(content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("modelId").ToString());
            Console.WriteLine(result.GetProperty("createdTime").ToString());
            Console.WriteLine(result.GetProperty("lastUpdatedTime").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Multivariate_TrainMultivariateModel_CreateAndTrainMultivariateModel_Convenience()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Multivariate client = new AnomalyDetectorClient(endpoint, credential).GetMultivariateClient();

            ModelInfo modelInfo = new ModelInfo(new Uri("https://multiadsample.blob.core.windows.net/data/sample_data_2_1000.csv"), DateTimeOffset.Parse("2019-04-01T00:00:00Z"), DateTimeOffset.Parse("2019-04-02T00:00:00Z"))
            {
                DataSchema = DataSchema.OneTable,
                DisplayName = "Devops-MultiAD",
                SlidingWindow = 20,
                AlignPolicy = new AlignPolicy
                {
                    AlignMode = AlignMode.Outer,
                    FillNAMethod = FillNAMethod.Linear,
                    PaddingValue = 0F,
                },
            };
            Response<AnomalyDetectionModel> response = client.TrainMultivariateModel(modelInfo);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Multivariate_TrainMultivariateModel_CreateAndTrainMultivariateModel_Convenience_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Multivariate client = new AnomalyDetectorClient(endpoint, credential).GetMultivariateClient();

            ModelInfo modelInfo = new ModelInfo(new Uri("https://multiadsample.blob.core.windows.net/data/sample_data_2_1000.csv"), DateTimeOffset.Parse("2019-04-01T00:00:00Z"), DateTimeOffset.Parse("2019-04-02T00:00:00Z"))
            {
                DataSchema = DataSchema.OneTable,
                DisplayName = "Devops-MultiAD",
                SlidingWindow = 20,
                AlignPolicy = new AlignPolicy
                {
                    AlignMode = AlignMode.Outer,
                    FillNAMethod = FillNAMethod.Linear,
                    PaddingValue = 0F,
                },
            };
            Response<AnomalyDetectionModel> response = await client.TrainMultivariateModelAsync(modelInfo);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Multivariate_DeleteMultivariateModel_DeleteMultivariateModel()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Multivariate client = new AnomalyDetectorClient(endpoint, credential).GetMultivariateClient();

            Response response = client.DeleteMultivariateModel("45aad126-aafd-11ea-b8fb-d89ef3400c5f");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Multivariate_DeleteMultivariateModel_DeleteMultivariateModel_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Multivariate client = new AnomalyDetectorClient(endpoint, credential).GetMultivariateClient();

            Response response = await client.DeleteMultivariateModelAsync("45aad126-aafd-11ea-b8fb-d89ef3400c5f");

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Multivariate_GetMultivariateModel_GetAMultivariateModel()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Multivariate client = new AnomalyDetectorClient(endpoint, credential).GetMultivariateClient();

            Response response = client.GetMultivariateModel("45aad126-aafd-11ea-b8fb-d89ef3400c5f", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("modelId").ToString());
            Console.WriteLine(result.GetProperty("createdTime").ToString());
            Console.WriteLine(result.GetProperty("lastUpdatedTime").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Multivariate_GetMultivariateModel_GetAMultivariateModel_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Multivariate client = new AnomalyDetectorClient(endpoint, credential).GetMultivariateClient();

            Response response = await client.GetMultivariateModelAsync("45aad126-aafd-11ea-b8fb-d89ef3400c5f", null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("modelId").ToString());
            Console.WriteLine(result.GetProperty("createdTime").ToString());
            Console.WriteLine(result.GetProperty("lastUpdatedTime").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Multivariate_GetMultivariateModel_GetAMultivariateModel_Convenience()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Multivariate client = new AnomalyDetectorClient(endpoint, credential).GetMultivariateClient();

            Response<AnomalyDetectionModel> response = client.GetMultivariateModel("45aad126-aafd-11ea-b8fb-d89ef3400c5f");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Multivariate_GetMultivariateModel_GetAMultivariateModel_Convenience_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Multivariate client = new AnomalyDetectorClient(endpoint, credential).GetMultivariateClient();

            Response<AnomalyDetectionModel> response = await client.GetMultivariateModelAsync("45aad126-aafd-11ea-b8fb-d89ef3400c5f");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Multivariate_DetectMultivariateBatchAnomaly_DetectMultivariateBatchAnomaly()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Multivariate client = new AnomalyDetectorClient(endpoint, credential).GetMultivariateClient();

            using RequestContent content = RequestContent.Create(new
            {
                dataSource = "https://multiadsample.blob.core.windows.net/data/sample_data_2_1000.csv",
                topContributorCount = 10,
                startTime = "2019-04-01T00:15:00Z",
                endTime = "2019-04-01T00:40:00Z",
            });
            Response response = client.DetectMultivariateBatchAnomaly("45aad126-aafd-11ea-b8fb-d89ef3400c5f", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("resultId").ToString());
            Console.WriteLine(result.GetProperty("summary").GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("summary").GetProperty("setupInfo").GetProperty("dataSource").ToString());
            Console.WriteLine(result.GetProperty("summary").GetProperty("setupInfo").GetProperty("startTime").ToString());
            Console.WriteLine(result.GetProperty("summary").GetProperty("setupInfo").GetProperty("endTime").ToString());
            Console.WriteLine(result.GetProperty("results")[0].GetProperty("timestamp").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Multivariate_DetectMultivariateBatchAnomaly_DetectMultivariateBatchAnomaly_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Multivariate client = new AnomalyDetectorClient(endpoint, credential).GetMultivariateClient();

            using RequestContent content = RequestContent.Create(new
            {
                dataSource = "https://multiadsample.blob.core.windows.net/data/sample_data_2_1000.csv",
                topContributorCount = 10,
                startTime = "2019-04-01T00:15:00Z",
                endTime = "2019-04-01T00:40:00Z",
            });
            Response response = await client.DetectMultivariateBatchAnomalyAsync("45aad126-aafd-11ea-b8fb-d89ef3400c5f", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("resultId").ToString());
            Console.WriteLine(result.GetProperty("summary").GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("summary").GetProperty("setupInfo").GetProperty("dataSource").ToString());
            Console.WriteLine(result.GetProperty("summary").GetProperty("setupInfo").GetProperty("startTime").ToString());
            Console.WriteLine(result.GetProperty("summary").GetProperty("setupInfo").GetProperty("endTime").ToString());
            Console.WriteLine(result.GetProperty("results")[0].GetProperty("timestamp").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Multivariate_DetectMultivariateBatchAnomaly_DetectMultivariateBatchAnomaly_Convenience()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Multivariate client = new AnomalyDetectorClient(endpoint, credential).GetMultivariateClient();

            MultivariateBatchDetectionOptions options = new MultivariateBatchDetectionOptions(new Uri("https://multiadsample.blob.core.windows.net/data/sample_data_2_1000.csv"), DateTimeOffset.Parse("2019-04-01T00:15:00Z"), DateTimeOffset.Parse("2019-04-01T00:40:00Z"))
            {
                TopContributorCount = 10,
            };
            Response<MultivariateDetectionResult> response = client.DetectMultivariateBatchAnomaly("45aad126-aafd-11ea-b8fb-d89ef3400c5f", options);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Multivariate_DetectMultivariateBatchAnomaly_DetectMultivariateBatchAnomaly_Convenience_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Multivariate client = new AnomalyDetectorClient(endpoint, credential).GetMultivariateClient();

            MultivariateBatchDetectionOptions options = new MultivariateBatchDetectionOptions(new Uri("https://multiadsample.blob.core.windows.net/data/sample_data_2_1000.csv"), DateTimeOffset.Parse("2019-04-01T00:15:00Z"), DateTimeOffset.Parse("2019-04-01T00:40:00Z"))
            {
                TopContributorCount = 10,
            };
            Response<MultivariateDetectionResult> response = await client.DetectMultivariateBatchAnomalyAsync("45aad126-aafd-11ea-b8fb-d89ef3400c5f", options);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Multivariate_DetectMultivariateLastAnomaly_DetectMultivariateLastAnomaly()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Multivariate client = new AnomalyDetectorClient(endpoint, credential).GetMultivariateClient();

            using RequestContent content = RequestContent.Create(new
            {
                variables = new object[]
            {
new
{
variable = "Variable_1",
timestamps = new object[]
{
"2021-01-01T00:00:00Z",
"2021-01-01T00:01:00Z",
"2021-01-01T00:02:00Z",
"2021-01-01T00:03:00Z",
"2021-01-01T00:04:00Z",
"2021-01-01T00:05:00Z",
"2021-01-01T00:06:00Z",
"2021-01-01T00:07:00Z",
"2021-01-01T00:08:00Z",
"2021-01-01T00:09:00Z",
"2021-01-01T00:10:00Z",
"2021-01-01T00:11:00Z",
"2021-01-01T00:12:00Z",
"2021-01-01T00:13:00Z",
"2021-01-01T00:14:00Z",
"2021-01-01T00:15:00Z",
"2021-01-01T00:16:00Z",
"2021-01-01T00:17:00Z",
"2021-01-01T00:18:00Z",
"2021-01-01T00:19:00Z",
"2021-01-01T00:20:00Z",
"2021-01-01T00:21:00Z",
"2021-01-01T00:22:00Z",
"2021-01-01T00:23:00Z",
"2021-01-01T00:24:00Z",
"2021-01-01T00:25:00Z",
"2021-01-01T00:26:00Z",
"2021-01-01T00:27:00Z",
"2021-01-01T00:28:00Z",
"2021-01-01T00:29:00Z"
},
values = new object[]
{
0.45513785F,
0.73886037F,
0.20108825F,
0.7462812F,
0.07308129F,
0.33090475F,
0.7544925F,
0.98750633F,
0.6665933F,
0.6308352F,
0.0808331F,
0.8414416F,
0.5145835F,
0.095448986F,
0.7786793F,
0.41646135F,
0.030176187F,
0.3474215F,
0.5085302F,
0.424512F,
0.21159442F,
0.2473352F,
0.87910223F,
0.94796216F,
0.26702702F,
0.69545037F,
0.12357284F,
0.82149154F,
0.11813002F,
0.8579046F
},
},
new
{
variable = "Variable_2",
timestamps = new object[]
{
"2021-01-01T00:00:00Z",
"2021-01-01T00:01:00Z",
"2021-01-01T00:02:00Z",
"2021-01-01T00:03:00Z",
"2021-01-01T00:04:00Z",
"2021-01-01T00:05:00Z",
"2021-01-01T00:06:00Z",
"2021-01-01T00:07:00Z",
"2021-01-01T00:08:00Z",
"2021-01-01T00:09:00Z",
"2021-01-01T00:10:00Z",
"2021-01-01T00:11:00Z",
"2021-01-01T00:12:00Z",
"2021-01-01T00:13:00Z",
"2021-01-01T00:14:00Z",
"2021-01-01T00:15:00Z",
"2021-01-01T00:16:00Z",
"2021-01-01T00:17:00Z",
"2021-01-01T00:18:00Z",
"2021-01-01T00:19:00Z",
"2021-01-01T00:20:00Z",
"2021-01-01T00:21:00Z",
"2021-01-01T00:22:00Z",
"2021-01-01T00:23:00Z",
"2021-01-01T00:24:00Z",
"2021-01-01T00:25:00Z",
"2021-01-01T00:26:00Z",
"2021-01-01T00:27:00Z",
"2021-01-01T00:28:00Z",
"2021-01-01T00:29:00Z"
},
values = new object[]
{
0.96178716F,
0.24903311F,
0.49205613F,
0.9895601F,
0.91717595F,
0.5754205F,
0.18110333F,
0.8852312F,
0.9543232F,
0.70880127F,
0.78435725F,
0.7664787F,
0.36995524F,
0.5045199F,
0.5848931F,
0.76289135F,
0.8148406F,
0.08540459F,
0.034819767F,
0.21275099F,
0.98361754F,
0.93214417F,
0.038466606F,
0.17231384F,
0.86263835F,
0.3505323F,
0.63114166F,
0.07303526F,
0.08886179F,
0.7488606F
},
},
new
{
variable = "Variable_3",
timestamps = new object[]
{
"2021-01-01T00:00:00Z",
"2021-01-01T00:01:00Z",
"2021-01-01T00:02:00Z",
"2021-01-01T00:03:00Z",
"2021-01-01T00:04:00Z",
"2021-01-01T00:05:00Z",
"2021-01-01T00:06:00Z",
"2021-01-01T00:07:00Z",
"2021-01-01T00:08:00Z",
"2021-01-01T00:09:00Z",
"2021-01-01T00:10:00Z",
"2021-01-01T00:11:00Z",
"2021-01-01T00:12:00Z",
"2021-01-01T00:13:00Z",
"2021-01-01T00:14:00Z",
"2021-01-01T00:15:00Z",
"2021-01-01T00:16:00Z",
"2021-01-01T00:17:00Z",
"2021-01-01T00:18:00Z",
"2021-01-01T00:19:00Z",
"2021-01-01T00:20:00Z",
"2021-01-01T00:21:00Z",
"2021-01-01T00:22:00Z",
"2021-01-01T00:23:00Z",
"2021-01-01T00:24:00Z",
"2021-01-01T00:25:00Z",
"2021-01-01T00:26:00Z",
"2021-01-01T00:27:00Z",
"2021-01-01T00:28:00Z",
"2021-01-01T00:29:00Z"
},
values = new object[]
{
0.4030757F,
0.1552689F,
0.36352226F,
0.60512006F,
0.8516795F,
0.26456058F,
0.68108755F,
0.91658944F,
0.70078325F,
0.56241554F,
0.62772894F,
0.15992056F,
0.60209644F,
0.35937968F,
0.8731686F,
0.20301549F,
0.029261872F,
0.62614995F,
0.4585078F,
0.8275007F,
0.03276027F,
0.44852027F,
0.8915691F,
0.89166903F,
0.94699794F,
0.115293086F,
0.088187724F,
0.74262863F,
0.32372248F,
0.93626815F
},
}
            },
                topContributorCount = 10,
            });
            Response response = client.DetectMultivariateLastAnomaly("45aad126-aafd-11ea-b8fb-d89ef3400c5f", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Multivariate_DetectMultivariateLastAnomaly_DetectMultivariateLastAnomaly_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Multivariate client = new AnomalyDetectorClient(endpoint, credential).GetMultivariateClient();

            using RequestContent content = RequestContent.Create(new
            {
                variables = new object[]
            {
new
{
variable = "Variable_1",
timestamps = new object[]
{
"2021-01-01T00:00:00Z",
"2021-01-01T00:01:00Z",
"2021-01-01T00:02:00Z",
"2021-01-01T00:03:00Z",
"2021-01-01T00:04:00Z",
"2021-01-01T00:05:00Z",
"2021-01-01T00:06:00Z",
"2021-01-01T00:07:00Z",
"2021-01-01T00:08:00Z",
"2021-01-01T00:09:00Z",
"2021-01-01T00:10:00Z",
"2021-01-01T00:11:00Z",
"2021-01-01T00:12:00Z",
"2021-01-01T00:13:00Z",
"2021-01-01T00:14:00Z",
"2021-01-01T00:15:00Z",
"2021-01-01T00:16:00Z",
"2021-01-01T00:17:00Z",
"2021-01-01T00:18:00Z",
"2021-01-01T00:19:00Z",
"2021-01-01T00:20:00Z",
"2021-01-01T00:21:00Z",
"2021-01-01T00:22:00Z",
"2021-01-01T00:23:00Z",
"2021-01-01T00:24:00Z",
"2021-01-01T00:25:00Z",
"2021-01-01T00:26:00Z",
"2021-01-01T00:27:00Z",
"2021-01-01T00:28:00Z",
"2021-01-01T00:29:00Z"
},
values = new object[]
{
0.45513785F,
0.73886037F,
0.20108825F,
0.7462812F,
0.07308129F,
0.33090475F,
0.7544925F,
0.98750633F,
0.6665933F,
0.6308352F,
0.0808331F,
0.8414416F,
0.5145835F,
0.095448986F,
0.7786793F,
0.41646135F,
0.030176187F,
0.3474215F,
0.5085302F,
0.424512F,
0.21159442F,
0.2473352F,
0.87910223F,
0.94796216F,
0.26702702F,
0.69545037F,
0.12357284F,
0.82149154F,
0.11813002F,
0.8579046F
},
},
new
{
variable = "Variable_2",
timestamps = new object[]
{
"2021-01-01T00:00:00Z",
"2021-01-01T00:01:00Z",
"2021-01-01T00:02:00Z",
"2021-01-01T00:03:00Z",
"2021-01-01T00:04:00Z",
"2021-01-01T00:05:00Z",
"2021-01-01T00:06:00Z",
"2021-01-01T00:07:00Z",
"2021-01-01T00:08:00Z",
"2021-01-01T00:09:00Z",
"2021-01-01T00:10:00Z",
"2021-01-01T00:11:00Z",
"2021-01-01T00:12:00Z",
"2021-01-01T00:13:00Z",
"2021-01-01T00:14:00Z",
"2021-01-01T00:15:00Z",
"2021-01-01T00:16:00Z",
"2021-01-01T00:17:00Z",
"2021-01-01T00:18:00Z",
"2021-01-01T00:19:00Z",
"2021-01-01T00:20:00Z",
"2021-01-01T00:21:00Z",
"2021-01-01T00:22:00Z",
"2021-01-01T00:23:00Z",
"2021-01-01T00:24:00Z",
"2021-01-01T00:25:00Z",
"2021-01-01T00:26:00Z",
"2021-01-01T00:27:00Z",
"2021-01-01T00:28:00Z",
"2021-01-01T00:29:00Z"
},
values = new object[]
{
0.96178716F,
0.24903311F,
0.49205613F,
0.9895601F,
0.91717595F,
0.5754205F,
0.18110333F,
0.8852312F,
0.9543232F,
0.70880127F,
0.78435725F,
0.7664787F,
0.36995524F,
0.5045199F,
0.5848931F,
0.76289135F,
0.8148406F,
0.08540459F,
0.034819767F,
0.21275099F,
0.98361754F,
0.93214417F,
0.038466606F,
0.17231384F,
0.86263835F,
0.3505323F,
0.63114166F,
0.07303526F,
0.08886179F,
0.7488606F
},
},
new
{
variable = "Variable_3",
timestamps = new object[]
{
"2021-01-01T00:00:00Z",
"2021-01-01T00:01:00Z",
"2021-01-01T00:02:00Z",
"2021-01-01T00:03:00Z",
"2021-01-01T00:04:00Z",
"2021-01-01T00:05:00Z",
"2021-01-01T00:06:00Z",
"2021-01-01T00:07:00Z",
"2021-01-01T00:08:00Z",
"2021-01-01T00:09:00Z",
"2021-01-01T00:10:00Z",
"2021-01-01T00:11:00Z",
"2021-01-01T00:12:00Z",
"2021-01-01T00:13:00Z",
"2021-01-01T00:14:00Z",
"2021-01-01T00:15:00Z",
"2021-01-01T00:16:00Z",
"2021-01-01T00:17:00Z",
"2021-01-01T00:18:00Z",
"2021-01-01T00:19:00Z",
"2021-01-01T00:20:00Z",
"2021-01-01T00:21:00Z",
"2021-01-01T00:22:00Z",
"2021-01-01T00:23:00Z",
"2021-01-01T00:24:00Z",
"2021-01-01T00:25:00Z",
"2021-01-01T00:26:00Z",
"2021-01-01T00:27:00Z",
"2021-01-01T00:28:00Z",
"2021-01-01T00:29:00Z"
},
values = new object[]
{
0.4030757F,
0.1552689F,
0.36352226F,
0.60512006F,
0.8516795F,
0.26456058F,
0.68108755F,
0.91658944F,
0.70078325F,
0.56241554F,
0.62772894F,
0.15992056F,
0.60209644F,
0.35937968F,
0.8731686F,
0.20301549F,
0.029261872F,
0.62614995F,
0.4585078F,
0.8275007F,
0.03276027F,
0.44852027F,
0.8915691F,
0.89166903F,
0.94699794F,
0.115293086F,
0.088187724F,
0.74262863F,
0.32372248F,
0.93626815F
},
}
            },
                topContributorCount = 10,
            });
            Response response = await client.DetectMultivariateLastAnomalyAsync("45aad126-aafd-11ea-b8fb-d89ef3400c5f", content);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Multivariate_DetectMultivariateLastAnomaly_DetectMultivariateLastAnomaly_Convenience()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Multivariate client = new AnomalyDetectorClient(endpoint, credential).GetMultivariateClient();

            MultivariateLastDetectionOptions options = new MultivariateLastDetectionOptions(new VariableValues[]
            {
new VariableValues("Variable_1", new string[]{"2021-01-01T00:00:00Z", "2021-01-01T00:01:00Z", "2021-01-01T00:02:00Z", "2021-01-01T00:03:00Z", "2021-01-01T00:04:00Z", "2021-01-01T00:05:00Z", "2021-01-01T00:06:00Z", "2021-01-01T00:07:00Z", "2021-01-01T00:08:00Z", "2021-01-01T00:09:00Z", "2021-01-01T00:10:00Z", "2021-01-01T00:11:00Z", "2021-01-01T00:12:00Z", "2021-01-01T00:13:00Z", "2021-01-01T00:14:00Z", "2021-01-01T00:15:00Z", "2021-01-01T00:16:00Z", "2021-01-01T00:17:00Z", "2021-01-01T00:18:00Z", "2021-01-01T00:19:00Z", "2021-01-01T00:20:00Z", "2021-01-01T00:21:00Z", "2021-01-01T00:22:00Z", "2021-01-01T00:23:00Z", "2021-01-01T00:24:00Z", "2021-01-01T00:25:00Z", "2021-01-01T00:26:00Z", "2021-01-01T00:27:00Z", "2021-01-01T00:28:00Z", "2021-01-01T00:29:00Z"}, new float[]{0.45513785F, 0.73886037F, 0.20108825F, 0.7462812F, 0.07308129F, 0.33090475F, 0.7544925F, 0.98750633F, 0.6665933F, 0.6308352F, 0.0808331F, 0.8414416F, 0.5145835F, 0.095448986F, 0.7786793F, 0.41646135F, 0.030176187F, 0.3474215F, 0.5085302F, 0.424512F, 0.21159442F, 0.2473352F, 0.87910223F, 0.94796216F, 0.26702702F, 0.69545037F, 0.12357284F, 0.82149154F, 0.11813002F, 0.8579046F}),
new VariableValues("Variable_2", new string[]{"2021-01-01T00:00:00Z", "2021-01-01T00:01:00Z", "2021-01-01T00:02:00Z", "2021-01-01T00:03:00Z", "2021-01-01T00:04:00Z", "2021-01-01T00:05:00Z", "2021-01-01T00:06:00Z", "2021-01-01T00:07:00Z", "2021-01-01T00:08:00Z", "2021-01-01T00:09:00Z", "2021-01-01T00:10:00Z", "2021-01-01T00:11:00Z", "2021-01-01T00:12:00Z", "2021-01-01T00:13:00Z", "2021-01-01T00:14:00Z", "2021-01-01T00:15:00Z", "2021-01-01T00:16:00Z", "2021-01-01T00:17:00Z", "2021-01-01T00:18:00Z", "2021-01-01T00:19:00Z", "2021-01-01T00:20:00Z", "2021-01-01T00:21:00Z", "2021-01-01T00:22:00Z", "2021-01-01T00:23:00Z", "2021-01-01T00:24:00Z", "2021-01-01T00:25:00Z", "2021-01-01T00:26:00Z", "2021-01-01T00:27:00Z", "2021-01-01T00:28:00Z", "2021-01-01T00:29:00Z"}, new float[]{0.96178716F, 0.24903311F, 0.49205613F, 0.9895601F, 0.91717595F, 0.5754205F, 0.18110333F, 0.8852312F, 0.9543232F, 0.70880127F, 0.78435725F, 0.7664787F, 0.36995524F, 0.5045199F, 0.5848931F, 0.76289135F, 0.8148406F, 0.08540459F, 0.034819767F, 0.21275099F, 0.98361754F, 0.93214417F, 0.038466606F, 0.17231384F, 0.86263835F, 0.3505323F, 0.63114166F, 0.07303526F, 0.08886179F, 0.7488606F}),
new VariableValues("Variable_3", new string[]{"2021-01-01T00:00:00Z", "2021-01-01T00:01:00Z", "2021-01-01T00:02:00Z", "2021-01-01T00:03:00Z", "2021-01-01T00:04:00Z", "2021-01-01T00:05:00Z", "2021-01-01T00:06:00Z", "2021-01-01T00:07:00Z", "2021-01-01T00:08:00Z", "2021-01-01T00:09:00Z", "2021-01-01T00:10:00Z", "2021-01-01T00:11:00Z", "2021-01-01T00:12:00Z", "2021-01-01T00:13:00Z", "2021-01-01T00:14:00Z", "2021-01-01T00:15:00Z", "2021-01-01T00:16:00Z", "2021-01-01T00:17:00Z", "2021-01-01T00:18:00Z", "2021-01-01T00:19:00Z", "2021-01-01T00:20:00Z", "2021-01-01T00:21:00Z", "2021-01-01T00:22:00Z", "2021-01-01T00:23:00Z", "2021-01-01T00:24:00Z", "2021-01-01T00:25:00Z", "2021-01-01T00:26:00Z", "2021-01-01T00:27:00Z", "2021-01-01T00:28:00Z", "2021-01-01T00:29:00Z"}, new float[]{0.4030757F, 0.1552689F, 0.36352226F, 0.60512006F, 0.8516795F, 0.26456058F, 0.68108755F, 0.91658944F, 0.70078325F, 0.56241554F, 0.62772894F, 0.15992056F, 0.60209644F, 0.35937968F, 0.8731686F, 0.20301549F, 0.029261872F, 0.62614995F, 0.4585078F, 0.8275007F, 0.03276027F, 0.44852027F, 0.8915691F, 0.89166903F, 0.94699794F, 0.115293086F, 0.088187724F, 0.74262863F, 0.32372248F, 0.93626815F})
            })
            {
                TopContributorCount = 10,
            };
            Response<MultivariateLastDetectionResult> response = client.DetectMultivariateLastAnomaly("45aad126-aafd-11ea-b8fb-d89ef3400c5f", options);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Multivariate_DetectMultivariateLastAnomaly_DetectMultivariateLastAnomaly_Convenience_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Multivariate client = new AnomalyDetectorClient(endpoint, credential).GetMultivariateClient();

            MultivariateLastDetectionOptions options = new MultivariateLastDetectionOptions(new VariableValues[]
            {
new VariableValues("Variable_1", new string[]{"2021-01-01T00:00:00Z", "2021-01-01T00:01:00Z", "2021-01-01T00:02:00Z", "2021-01-01T00:03:00Z", "2021-01-01T00:04:00Z", "2021-01-01T00:05:00Z", "2021-01-01T00:06:00Z", "2021-01-01T00:07:00Z", "2021-01-01T00:08:00Z", "2021-01-01T00:09:00Z", "2021-01-01T00:10:00Z", "2021-01-01T00:11:00Z", "2021-01-01T00:12:00Z", "2021-01-01T00:13:00Z", "2021-01-01T00:14:00Z", "2021-01-01T00:15:00Z", "2021-01-01T00:16:00Z", "2021-01-01T00:17:00Z", "2021-01-01T00:18:00Z", "2021-01-01T00:19:00Z", "2021-01-01T00:20:00Z", "2021-01-01T00:21:00Z", "2021-01-01T00:22:00Z", "2021-01-01T00:23:00Z", "2021-01-01T00:24:00Z", "2021-01-01T00:25:00Z", "2021-01-01T00:26:00Z", "2021-01-01T00:27:00Z", "2021-01-01T00:28:00Z", "2021-01-01T00:29:00Z"}, new float[]{0.45513785F, 0.73886037F, 0.20108825F, 0.7462812F, 0.07308129F, 0.33090475F, 0.7544925F, 0.98750633F, 0.6665933F, 0.6308352F, 0.0808331F, 0.8414416F, 0.5145835F, 0.095448986F, 0.7786793F, 0.41646135F, 0.030176187F, 0.3474215F, 0.5085302F, 0.424512F, 0.21159442F, 0.2473352F, 0.87910223F, 0.94796216F, 0.26702702F, 0.69545037F, 0.12357284F, 0.82149154F, 0.11813002F, 0.8579046F}),
new VariableValues("Variable_2", new string[]{"2021-01-01T00:00:00Z", "2021-01-01T00:01:00Z", "2021-01-01T00:02:00Z", "2021-01-01T00:03:00Z", "2021-01-01T00:04:00Z", "2021-01-01T00:05:00Z", "2021-01-01T00:06:00Z", "2021-01-01T00:07:00Z", "2021-01-01T00:08:00Z", "2021-01-01T00:09:00Z", "2021-01-01T00:10:00Z", "2021-01-01T00:11:00Z", "2021-01-01T00:12:00Z", "2021-01-01T00:13:00Z", "2021-01-01T00:14:00Z", "2021-01-01T00:15:00Z", "2021-01-01T00:16:00Z", "2021-01-01T00:17:00Z", "2021-01-01T00:18:00Z", "2021-01-01T00:19:00Z", "2021-01-01T00:20:00Z", "2021-01-01T00:21:00Z", "2021-01-01T00:22:00Z", "2021-01-01T00:23:00Z", "2021-01-01T00:24:00Z", "2021-01-01T00:25:00Z", "2021-01-01T00:26:00Z", "2021-01-01T00:27:00Z", "2021-01-01T00:28:00Z", "2021-01-01T00:29:00Z"}, new float[]{0.96178716F, 0.24903311F, 0.49205613F, 0.9895601F, 0.91717595F, 0.5754205F, 0.18110333F, 0.8852312F, 0.9543232F, 0.70880127F, 0.78435725F, 0.7664787F, 0.36995524F, 0.5045199F, 0.5848931F, 0.76289135F, 0.8148406F, 0.08540459F, 0.034819767F, 0.21275099F, 0.98361754F, 0.93214417F, 0.038466606F, 0.17231384F, 0.86263835F, 0.3505323F, 0.63114166F, 0.07303526F, 0.08886179F, 0.7488606F}),
new VariableValues("Variable_3", new string[]{"2021-01-01T00:00:00Z", "2021-01-01T00:01:00Z", "2021-01-01T00:02:00Z", "2021-01-01T00:03:00Z", "2021-01-01T00:04:00Z", "2021-01-01T00:05:00Z", "2021-01-01T00:06:00Z", "2021-01-01T00:07:00Z", "2021-01-01T00:08:00Z", "2021-01-01T00:09:00Z", "2021-01-01T00:10:00Z", "2021-01-01T00:11:00Z", "2021-01-01T00:12:00Z", "2021-01-01T00:13:00Z", "2021-01-01T00:14:00Z", "2021-01-01T00:15:00Z", "2021-01-01T00:16:00Z", "2021-01-01T00:17:00Z", "2021-01-01T00:18:00Z", "2021-01-01T00:19:00Z", "2021-01-01T00:20:00Z", "2021-01-01T00:21:00Z", "2021-01-01T00:22:00Z", "2021-01-01T00:23:00Z", "2021-01-01T00:24:00Z", "2021-01-01T00:25:00Z", "2021-01-01T00:26:00Z", "2021-01-01T00:27:00Z", "2021-01-01T00:28:00Z", "2021-01-01T00:29:00Z"}, new float[]{0.4030757F, 0.1552689F, 0.36352226F, 0.60512006F, 0.8516795F, 0.26456058F, 0.68108755F, 0.91658944F, 0.70078325F, 0.56241554F, 0.62772894F, 0.15992056F, 0.60209644F, 0.35937968F, 0.8731686F, 0.20301549F, 0.029261872F, 0.62614995F, 0.4585078F, 0.8275007F, 0.03276027F, 0.44852027F, 0.8915691F, 0.89166903F, 0.94699794F, 0.115293086F, 0.088187724F, 0.74262863F, 0.32372248F, 0.93626815F})
            })
            {
                TopContributorCount = 10,
            };
            Response<MultivariateLastDetectionResult> response = await client.DetectMultivariateLastAnomalyAsync("45aad126-aafd-11ea-b8fb-d89ef3400c5f", options);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Multivariate_GetMultivariateModels_ListMultivariateModels()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Multivariate client = new AnomalyDetectorClient(endpoint, credential).GetMultivariateClient();

            foreach (BinaryData item in client.GetMultivariateModels(0, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("modelId").ToString());
                Console.WriteLine(result.GetProperty("createdTime").ToString());
                Console.WriteLine(result.GetProperty("lastUpdatedTime").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Multivariate_GetMultivariateModels_ListMultivariateModels_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Multivariate client = new AnomalyDetectorClient(endpoint, credential).GetMultivariateClient();

            await foreach (BinaryData item in client.GetMultivariateModelsAsync(0, null, null))
            {
                JsonElement result = JsonDocument.Parse(item.ToStream()).RootElement;
                Console.WriteLine(result.GetProperty("modelId").ToString());
                Console.WriteLine(result.GetProperty("createdTime").ToString());
                Console.WriteLine(result.GetProperty("lastUpdatedTime").ToString());
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Multivariate_GetMultivariateModels_ListMultivariateModels_Convenience()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Multivariate client = new AnomalyDetectorClient(endpoint, credential).GetMultivariateClient();

            foreach (AnomalyDetectionModel item in client.GetMultivariateModels())
            {
            }
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Multivariate_GetMultivariateModels_ListMultivariateModels_Convenience_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            Multivariate client = new AnomalyDetectorClient(endpoint, credential).GetMultivariateClient();

            await foreach (AnomalyDetectionModel item in client.GetMultivariateModelsAsync())
            {
            }
        }
    }
}
