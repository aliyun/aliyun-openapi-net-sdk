/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.PTS.Model.V20201020;

namespace Aliyun.Acs.PTS.Transform.V20201020
{
    public class GetPtsReportDetailsResponseUnmarshaller
    {
        public static GetPtsReportDetailsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetPtsReportDetailsResponse getPtsReportDetailsResponse = new GetPtsReportDetailsResponse();

			getPtsReportDetailsResponse.HttpResponse = _ctx.HttpResponse;
			getPtsReportDetailsResponse.Message = _ctx.StringValue("GetPtsReportDetails.Message");
			getPtsReportDetailsResponse.RequestId = _ctx.StringValue("GetPtsReportDetails.RequestId");
			getPtsReportDetailsResponse.HttpStatusCode = _ctx.IntegerValue("GetPtsReportDetails.HttpStatusCode");
			getPtsReportDetailsResponse.Code = _ctx.StringValue("GetPtsReportDetails.Code");
			getPtsReportDetailsResponse.Success = _ctx.BooleanValue("GetPtsReportDetails.Success");

			GetPtsReportDetailsResponse.GetPtsReportDetails_ReportOverView reportOverView = new GetPtsReportDetailsResponse.GetPtsReportDetails_ReportOverView();
			reportOverView.ReportName = _ctx.StringValue("GetPtsReportDetails.ReportOverView.ReportName");
			reportOverView.EndTime = _ctx.StringValue("GetPtsReportDetails.ReportOverView.EndTime");
			reportOverView.StartTime = _ctx.StringValue("GetPtsReportDetails.ReportOverView.StartTime");
			reportOverView.AgentCount = _ctx.IntegerValue("GetPtsReportDetails.ReportOverView.AgentCount");
			reportOverView.ReportId = _ctx.StringValue("GetPtsReportDetails.ReportOverView.ReportId");
			reportOverView.Vum = _ctx.LongValue("GetPtsReportDetails.ReportOverView.Vum");
			getPtsReportDetailsResponse.ReportOverView = reportOverView;

			GetPtsReportDetailsResponse.GetPtsReportDetails_SceneMetrics sceneMetrics = new GetPtsReportDetailsResponse.GetPtsReportDetails_SceneMetrics();
			sceneMetrics.FailCountBiz = _ctx.LongValue("GetPtsReportDetails.SceneMetrics.FailCountBiz");
			sceneMetrics.AllCount = _ctx.LongValue("GetPtsReportDetails.SceneMetrics.AllCount");
			sceneMetrics.SuccessRateBiz = _ctx.FloatValue("GetPtsReportDetails.SceneMetrics.SuccessRateBiz");
			sceneMetrics.AvgRt = _ctx.FloatValue("GetPtsReportDetails.SceneMetrics.AvgRt");
			sceneMetrics.FailCountReq = _ctx.LongValue("GetPtsReportDetails.SceneMetrics.FailCountReq");
			sceneMetrics.AvgTps = _ctx.FloatValue("GetPtsReportDetails.SceneMetrics.AvgTps");
			sceneMetrics.Seg99Rt = _ctx.FloatValue("GetPtsReportDetails.SceneMetrics.Seg99Rt");
			sceneMetrics.SuccessRateReq = _ctx.FloatValue("GetPtsReportDetails.SceneMetrics.SuccessRateReq");
			sceneMetrics.Seg90Rt = _ctx.FloatValue("GetPtsReportDetails.SceneMetrics.Seg90Rt");
			getPtsReportDetailsResponse.SceneMetrics = sceneMetrics;

			GetPtsReportDetailsResponse.GetPtsReportDetails_SceneSnapShot sceneSnapShot = new GetPtsReportDetailsResponse.GetPtsReportDetails_SceneSnapShot();
			sceneSnapShot.Status = _ctx.StringValue("GetPtsReportDetails.SceneSnapShot.Status");
			sceneSnapShot.ModifiedTime = _ctx.StringValue("GetPtsReportDetails.SceneSnapShot.ModifiedTime");
			sceneSnapShot.CreateTime = _ctx.StringValue("GetPtsReportDetails.SceneSnapShot.CreateTime");
			sceneSnapShot.SceneName = _ctx.StringValue("GetPtsReportDetails.SceneSnapShot.SceneName");
			sceneSnapShot.SceneId = _ctx.StringValue("GetPtsReportDetails.SceneSnapShot.SceneId");

			GetPtsReportDetailsResponse.GetPtsReportDetails_SceneSnapShot.GetPtsReportDetails_LoadConfig loadConfig = new GetPtsReportDetailsResponse.GetPtsReportDetails_SceneSnapShot.GetPtsReportDetails_LoadConfig();
			loadConfig.MaxRunningTime = _ctx.IntegerValue("GetPtsReportDetails.SceneSnapShot.LoadConfig.MaxRunningTime");
			loadConfig.AgentCount = _ctx.IntegerValue("GetPtsReportDetails.SceneSnapShot.LoadConfig.AgentCount");
			loadConfig.TestMode = _ctx.StringValue("GetPtsReportDetails.SceneSnapShot.LoadConfig.TestMode");

			GetPtsReportDetailsResponse.GetPtsReportDetails_SceneSnapShot.GetPtsReportDetails_LoadConfig.GetPtsReportDetails_Configuration configuration = new GetPtsReportDetailsResponse.GetPtsReportDetails_SceneSnapShot.GetPtsReportDetails_LoadConfig.GetPtsReportDetails_Configuration();
			configuration.AllRpsBegin = _ctx.IntegerValue("GetPtsReportDetails.SceneSnapShot.LoadConfig.Configuration.AllRpsBegin");
			configuration.AllConcurrencyBegin = _ctx.IntegerValue("GetPtsReportDetails.SceneSnapShot.LoadConfig.Configuration.AllConcurrencyBegin");
			configuration.AllConcurrencyLimit = _ctx.IntegerValue("GetPtsReportDetails.SceneSnapShot.LoadConfig.Configuration.AllConcurrencyLimit");
			configuration.AllRpsLimit = _ctx.IntegerValue("GetPtsReportDetails.SceneSnapShot.LoadConfig.Configuration.AllRpsLimit");
			loadConfig.Configuration = configuration;

			List<GetPtsReportDetailsResponse.GetPtsReportDetails_SceneSnapShot.GetPtsReportDetails_LoadConfig.GetPtsReportDetails_ApiLoadConfig> loadConfig_apiLoadConfigList = new List<GetPtsReportDetailsResponse.GetPtsReportDetails_SceneSnapShot.GetPtsReportDetails_LoadConfig.GetPtsReportDetails_ApiLoadConfig>();
			for (int i = 0; i < _ctx.Length("GetPtsReportDetails.SceneSnapShot.LoadConfig.ApiLoadConfigList.Length"); i++) {
				GetPtsReportDetailsResponse.GetPtsReportDetails_SceneSnapShot.GetPtsReportDetails_LoadConfig.GetPtsReportDetails_ApiLoadConfig apiLoadConfig = new GetPtsReportDetailsResponse.GetPtsReportDetails_SceneSnapShot.GetPtsReportDetails_LoadConfig.GetPtsReportDetails_ApiLoadConfig();
				apiLoadConfig.RpsBegin = _ctx.IntegerValue("GetPtsReportDetails.SceneSnapShot.LoadConfig.ApiLoadConfigList["+ i +"].RpsBegin");
				apiLoadConfig.RpsLimit = _ctx.IntegerValue("GetPtsReportDetails.SceneSnapShot.LoadConfig.ApiLoadConfigList["+ i +"].RpsLimit");

				loadConfig_apiLoadConfigList.Add(apiLoadConfig);
			}
			loadConfig.ApiLoadConfigList = loadConfig_apiLoadConfigList;

			List<GetPtsReportDetailsResponse.GetPtsReportDetails_SceneSnapShot.GetPtsReportDetails_LoadConfig.GetPtsReportDetails_RelationLoadConfig> loadConfig_relationLoadConfigList = new List<GetPtsReportDetailsResponse.GetPtsReportDetails_SceneSnapShot.GetPtsReportDetails_LoadConfig.GetPtsReportDetails_RelationLoadConfig>();
			for (int i = 0; i < _ctx.Length("GetPtsReportDetails.SceneSnapShot.LoadConfig.RelationLoadConfigList.Length"); i++) {
				GetPtsReportDetailsResponse.GetPtsReportDetails_SceneSnapShot.GetPtsReportDetails_LoadConfig.GetPtsReportDetails_RelationLoadConfig relationLoadConfig = new GetPtsReportDetailsResponse.GetPtsReportDetails_SceneSnapShot.GetPtsReportDetails_LoadConfig.GetPtsReportDetails_RelationLoadConfig();
				relationLoadConfig.ConcurrencyBegin = _ctx.IntegerValue("GetPtsReportDetails.SceneSnapShot.LoadConfig.RelationLoadConfigList["+ i +"].ConcurrencyBegin");
				relationLoadConfig.ConcurrencyLimit = _ctx.IntegerValue("GetPtsReportDetails.SceneSnapShot.LoadConfig.RelationLoadConfigList["+ i +"].ConcurrencyLimit");

				loadConfig_relationLoadConfigList.Add(relationLoadConfig);
			}
			loadConfig.RelationLoadConfigList = loadConfig_relationLoadConfigList;
			sceneSnapShot.LoadConfig = loadConfig;

			GetPtsReportDetailsResponse.GetPtsReportDetails_SceneSnapShot.GetPtsReportDetails_AdvanceSetting advanceSetting = new GetPtsReportDetailsResponse.GetPtsReportDetails_SceneSnapShot.GetPtsReportDetails_AdvanceSetting();
			advanceSetting.LogRate = _ctx.IntegerValue("GetPtsReportDetails.SceneSnapShot.AdvanceSetting.LogRate");
			advanceSetting.ConnectionTimeoutInSecond = _ctx.IntegerValue("GetPtsReportDetails.SceneSnapShot.AdvanceSetting.ConnectionTimeoutInSecond");
			advanceSetting.SuccessCode = _ctx.StringValue("GetPtsReportDetails.SceneSnapShot.AdvanceSetting.SuccessCode");

			List<GetPtsReportDetailsResponse.GetPtsReportDetails_SceneSnapShot.GetPtsReportDetails_AdvanceSetting.GetPtsReportDetails_DomainBinding> advanceSetting_domainBindingList = new List<GetPtsReportDetailsResponse.GetPtsReportDetails_SceneSnapShot.GetPtsReportDetails_AdvanceSetting.GetPtsReportDetails_DomainBinding>();
			for (int i = 0; i < _ctx.Length("GetPtsReportDetails.SceneSnapShot.AdvanceSetting.DomainBindingList.Length"); i++) {
				GetPtsReportDetailsResponse.GetPtsReportDetails_SceneSnapShot.GetPtsReportDetails_AdvanceSetting.GetPtsReportDetails_DomainBinding domainBinding = new GetPtsReportDetailsResponse.GetPtsReportDetails_SceneSnapShot.GetPtsReportDetails_AdvanceSetting.GetPtsReportDetails_DomainBinding();
				domainBinding.Domain = _ctx.StringValue("GetPtsReportDetails.SceneSnapShot.AdvanceSetting.DomainBindingList["+ i +"].Domain");

				List<string> domainBinding_ips = new List<string>();
				for (int j = 0; j < _ctx.Length("GetPtsReportDetails.SceneSnapShot.AdvanceSetting.DomainBindingList["+ i +"].Ips.Length"); j++) {
					domainBinding_ips.Add(_ctx.StringValue("GetPtsReportDetails.SceneSnapShot.AdvanceSetting.DomainBindingList["+ i +"].Ips["+ j +"]"));
				}
				domainBinding.Ips = domainBinding_ips;

				advanceSetting_domainBindingList.Add(domainBinding);
			}
			advanceSetting.DomainBindingList = advanceSetting_domainBindingList;
			sceneSnapShot.AdvanceSetting = advanceSetting;

			List<GetPtsReportDetailsResponse.GetPtsReportDetails_SceneSnapShot.GetPtsReportDetails_FileParameter> sceneSnapShot_fileParameterList = new List<GetPtsReportDetailsResponse.GetPtsReportDetails_SceneSnapShot.GetPtsReportDetails_FileParameter>();
			for (int i = 0; i < _ctx.Length("GetPtsReportDetails.SceneSnapShot.FileParameterList.Length"); i++) {
				GetPtsReportDetailsResponse.GetPtsReportDetails_SceneSnapShot.GetPtsReportDetails_FileParameter fileParameter = new GetPtsReportDetailsResponse.GetPtsReportDetails_SceneSnapShot.GetPtsReportDetails_FileParameter();
				fileParameter.FileOssAddress = _ctx.StringValue("GetPtsReportDetails.SceneSnapShot.FileParameterList["+ i +"].FileOssAddress");
				fileParameter.FileName = _ctx.StringValue("GetPtsReportDetails.SceneSnapShot.FileParameterList["+ i +"].FileName");

				sceneSnapShot_fileParameterList.Add(fileParameter);
			}
			sceneSnapShot.FileParameterList = sceneSnapShot_fileParameterList;

			List<GetPtsReportDetailsResponse.GetPtsReportDetails_SceneSnapShot.GetPtsReportDetails_Relation> sceneSnapShot_relationList = new List<GetPtsReportDetailsResponse.GetPtsReportDetails_SceneSnapShot.GetPtsReportDetails_Relation>();
			for (int i = 0; i < _ctx.Length("GetPtsReportDetails.SceneSnapShot.RelationList.Length"); i++) {
				GetPtsReportDetailsResponse.GetPtsReportDetails_SceneSnapShot.GetPtsReportDetails_Relation relation = new GetPtsReportDetailsResponse.GetPtsReportDetails_SceneSnapShot.GetPtsReportDetails_Relation();
				relation.RelationName = _ctx.StringValue("GetPtsReportDetails.SceneSnapShot.RelationList["+ i +"].RelationName");
				relation.RelationId = _ctx.StringValue("GetPtsReportDetails.SceneSnapShot.RelationList["+ i +"].RelationId");

				List<GetPtsReportDetailsResponse.GetPtsReportDetails_SceneSnapShot.GetPtsReportDetails_Relation.GetPtsReportDetails_FileParameterExplain> relation_fileParameterExplainList = new List<GetPtsReportDetailsResponse.GetPtsReportDetails_SceneSnapShot.GetPtsReportDetails_Relation.GetPtsReportDetails_FileParameterExplain>();
				for (int j = 0; j < _ctx.Length("GetPtsReportDetails.SceneSnapShot.RelationList["+ i +"].FileParameterExplainList.Length"); j++) {
					GetPtsReportDetailsResponse.GetPtsReportDetails_SceneSnapShot.GetPtsReportDetails_Relation.GetPtsReportDetails_FileParameterExplain fileParameterExplain = new GetPtsReportDetailsResponse.GetPtsReportDetails_SceneSnapShot.GetPtsReportDetails_Relation.GetPtsReportDetails_FileParameterExplain();
					fileParameterExplain.CycleOnce = _ctx.BooleanValue("GetPtsReportDetails.SceneSnapShot.RelationList["+ i +"].FileParameterExplainList["+ j +"].CycleOnce");
					fileParameterExplain.FileParamName = _ctx.StringValue("GetPtsReportDetails.SceneSnapShot.RelationList["+ i +"].FileParameterExplainList["+ j +"].FileParamName");
					fileParameterExplain.FileName = _ctx.StringValue("GetPtsReportDetails.SceneSnapShot.RelationList["+ i +"].FileParameterExplainList["+ j +"].FileName");
					fileParameterExplain.BaseFile = _ctx.BooleanValue("GetPtsReportDetails.SceneSnapShot.RelationList["+ i +"].FileParameterExplainList["+ j +"].BaseFile");

					relation_fileParameterExplainList.Add(fileParameterExplain);
				}
				relation.FileParameterExplainList = relation_fileParameterExplainList;

				List<GetPtsReportDetailsResponse.GetPtsReportDetails_SceneSnapShot.GetPtsReportDetails_Relation.GetPtsReportDetails_Api> relation_apiList = new List<GetPtsReportDetailsResponse.GetPtsReportDetails_SceneSnapShot.GetPtsReportDetails_Relation.GetPtsReportDetails_Api>();
				for (int j = 0; j < _ctx.Length("GetPtsReportDetails.SceneSnapShot.RelationList["+ i +"].ApiList.Length"); j++) {
					GetPtsReportDetailsResponse.GetPtsReportDetails_SceneSnapShot.GetPtsReportDetails_Relation.GetPtsReportDetails_Api api = new GetPtsReportDetailsResponse.GetPtsReportDetails_SceneSnapShot.GetPtsReportDetails_Relation.GetPtsReportDetails_Api();
					api.ApiId = _ctx.StringValue("GetPtsReportDetails.SceneSnapShot.RelationList["+ i +"].ApiList["+ j +"].ApiId");
					api.TimeoutInSecond = _ctx.IntegerValue("GetPtsReportDetails.SceneSnapShot.RelationList["+ i +"].ApiList["+ j +"].TimeoutInSecond");
					api.Url = _ctx.StringValue("GetPtsReportDetails.SceneSnapShot.RelationList["+ i +"].ApiList["+ j +"].Url");
					api.Method = _ctx.StringValue("GetPtsReportDetails.SceneSnapShot.RelationList["+ i +"].ApiList["+ j +"].Method");
					api.RedirectCountLimit = _ctx.IntegerValue("GetPtsReportDetails.SceneSnapShot.RelationList["+ i +"].ApiList["+ j +"].RedirectCountLimit");
					api.ApiName = _ctx.StringValue("GetPtsReportDetails.SceneSnapShot.RelationList["+ i +"].ApiList["+ j +"].ApiName");

					GetPtsReportDetailsResponse.GetPtsReportDetails_SceneSnapShot.GetPtsReportDetails_Relation.GetPtsReportDetails_Api.GetPtsReportDetails_Body body = new GetPtsReportDetailsResponse.GetPtsReportDetails_SceneSnapShot.GetPtsReportDetails_Relation.GetPtsReportDetails_Api.GetPtsReportDetails_Body();
					body.BodyValue = _ctx.StringValue("GetPtsReportDetails.SceneSnapShot.RelationList["+ i +"].ApiList["+ j +"].Body.BodyValue");
					body.ContentType = _ctx.StringValue("GetPtsReportDetails.SceneSnapShot.RelationList["+ i +"].ApiList["+ j +"].Body.ContentType");
					api.Body = body;

					List<GetPtsReportDetailsResponse.GetPtsReportDetails_SceneSnapShot.GetPtsReportDetails_Relation.GetPtsReportDetails_Api.GetPtsReportDetails_CheckPoint> api_checkPointList = new List<GetPtsReportDetailsResponse.GetPtsReportDetails_SceneSnapShot.GetPtsReportDetails_Relation.GetPtsReportDetails_Api.GetPtsReportDetails_CheckPoint>();
					for (int k = 0; k < _ctx.Length("GetPtsReportDetails.SceneSnapShot.RelationList["+ i +"].ApiList["+ j +"].CheckPointList.Length"); k++) {
						GetPtsReportDetailsResponse.GetPtsReportDetails_SceneSnapShot.GetPtsReportDetails_Relation.GetPtsReportDetails_Api.GetPtsReportDetails_CheckPoint checkPoint = new GetPtsReportDetailsResponse.GetPtsReportDetails_SceneSnapShot.GetPtsReportDetails_Relation.GetPtsReportDetails_Api.GetPtsReportDetails_CheckPoint();
						checkPoint.CheckType = _ctx.StringValue("GetPtsReportDetails.SceneSnapShot.RelationList["+ i +"].ApiList["+ j +"].CheckPointList["+ k +"].CheckType");
						checkPoint._Operator = _ctx.StringValue("GetPtsReportDetails.SceneSnapShot.RelationList["+ i +"].ApiList["+ j +"].CheckPointList["+ k +"].Operator");
						checkPoint.ExpectValue = _ctx.StringValue("GetPtsReportDetails.SceneSnapShot.RelationList["+ i +"].ApiList["+ j +"].CheckPointList["+ k +"].ExpectValue");
						checkPoint.CheckPoint = _ctx.StringValue("GetPtsReportDetails.SceneSnapShot.RelationList["+ i +"].ApiList["+ j +"].CheckPointList["+ k +"].CheckPoint");

						api_checkPointList.Add(checkPoint);
					}
					api.CheckPointList = api_checkPointList;

					List<GetPtsReportDetailsResponse.GetPtsReportDetails_SceneSnapShot.GetPtsReportDetails_Relation.GetPtsReportDetails_Api.GetPtsReportDetails_Header> api_headerList = new List<GetPtsReportDetailsResponse.GetPtsReportDetails_SceneSnapShot.GetPtsReportDetails_Relation.GetPtsReportDetails_Api.GetPtsReportDetails_Header>();
					for (int k = 0; k < _ctx.Length("GetPtsReportDetails.SceneSnapShot.RelationList["+ i +"].ApiList["+ j +"].HeaderList.Length"); k++) {
						GetPtsReportDetailsResponse.GetPtsReportDetails_SceneSnapShot.GetPtsReportDetails_Relation.GetPtsReportDetails_Api.GetPtsReportDetails_Header header = new GetPtsReportDetailsResponse.GetPtsReportDetails_SceneSnapShot.GetPtsReportDetails_Relation.GetPtsReportDetails_Api.GetPtsReportDetails_Header();
						header.HeaderValue = _ctx.StringValue("GetPtsReportDetails.SceneSnapShot.RelationList["+ i +"].ApiList["+ j +"].HeaderList["+ k +"].HeaderValue");
						header.HeaderName = _ctx.StringValue("GetPtsReportDetails.SceneSnapShot.RelationList["+ i +"].ApiList["+ j +"].HeaderList["+ k +"].HeaderName");

						api_headerList.Add(header);
					}
					api.HeaderList = api_headerList;

					List<GetPtsReportDetailsResponse.GetPtsReportDetails_SceneSnapShot.GetPtsReportDetails_Relation.GetPtsReportDetails_Api.GetPtsReportDetails_Export> api_exportList = new List<GetPtsReportDetailsResponse.GetPtsReportDetails_SceneSnapShot.GetPtsReportDetails_Relation.GetPtsReportDetails_Api.GetPtsReportDetails_Export>();
					for (int k = 0; k < _ctx.Length("GetPtsReportDetails.SceneSnapShot.RelationList["+ i +"].ApiList["+ j +"].ExportList.Length"); k++) {
						GetPtsReportDetailsResponse.GetPtsReportDetails_SceneSnapShot.GetPtsReportDetails_Relation.GetPtsReportDetails_Api.GetPtsReportDetails_Export export = new GetPtsReportDetailsResponse.GetPtsReportDetails_SceneSnapShot.GetPtsReportDetails_Relation.GetPtsReportDetails_Api.GetPtsReportDetails_Export();
						export.ExportType = _ctx.StringValue("GetPtsReportDetails.SceneSnapShot.RelationList["+ i +"].ApiList["+ j +"].ExportList["+ k +"].ExportType");
						export.ExportValue = _ctx.StringValue("GetPtsReportDetails.SceneSnapShot.RelationList["+ i +"].ApiList["+ j +"].ExportList["+ k +"].ExportValue");
						export.ExportName = _ctx.StringValue("GetPtsReportDetails.SceneSnapShot.RelationList["+ i +"].ApiList["+ j +"].ExportList["+ k +"].ExportName");
						export.Count = _ctx.StringValue("GetPtsReportDetails.SceneSnapShot.RelationList["+ i +"].ApiList["+ j +"].ExportList["+ k +"].Count");

						api_exportList.Add(export);
					}
					api.ExportList = api_exportList;

					relation_apiList.Add(api);
				}
				relation.ApiList = relation_apiList;

				sceneSnapShot_relationList.Add(relation);
			}
			sceneSnapShot.RelationList = sceneSnapShot_relationList;

			List<GetPtsReportDetailsResponse.GetPtsReportDetails_SceneSnapShot.GetPtsReportDetails_GlobalParameter> sceneSnapShot_globalParameterList = new List<GetPtsReportDetailsResponse.GetPtsReportDetails_SceneSnapShot.GetPtsReportDetails_GlobalParameter>();
			for (int i = 0; i < _ctx.Length("GetPtsReportDetails.SceneSnapShot.GlobalParameterList.Length"); i++) {
				GetPtsReportDetailsResponse.GetPtsReportDetails_SceneSnapShot.GetPtsReportDetails_GlobalParameter globalParameter = new GetPtsReportDetailsResponse.GetPtsReportDetails_SceneSnapShot.GetPtsReportDetails_GlobalParameter();
				globalParameter.ParamName = _ctx.StringValue("GetPtsReportDetails.SceneSnapShot.GlobalParameterList["+ i +"].ParamName");
				globalParameter.ParamValue = _ctx.StringValue("GetPtsReportDetails.SceneSnapShot.GlobalParameterList["+ i +"].ParamValue");

				sceneSnapShot_globalParameterList.Add(globalParameter);
			}
			sceneSnapShot.GlobalParameterList = sceneSnapShot_globalParameterList;
			getPtsReportDetailsResponse.SceneSnapShot = sceneSnapShot;

			List<GetPtsReportDetailsResponse.GetPtsReportDetails_ApiMetrics> getPtsReportDetailsResponse_apiMetricsList = new List<GetPtsReportDetailsResponse.GetPtsReportDetails_ApiMetrics>();
			for (int i = 0; i < _ctx.Length("GetPtsReportDetails.ApiMetricsList.Length"); i++) {
				GetPtsReportDetailsResponse.GetPtsReportDetails_ApiMetrics apiMetrics = new GetPtsReportDetailsResponse.GetPtsReportDetails_ApiMetrics();
				apiMetrics.FailCountBiz = _ctx.LongValue("GetPtsReportDetails.ApiMetricsList["+ i +"].FailCountBiz");
				apiMetrics.Seg75Rt = _ctx.FloatValue("GetPtsReportDetails.ApiMetricsList["+ i +"].Seg75Rt");
				apiMetrics.AllCount = _ctx.LongValue("GetPtsReportDetails.ApiMetricsList["+ i +"].AllCount");
				apiMetrics.AvgTps = _ctx.FloatValue("GetPtsReportDetails.ApiMetricsList["+ i +"].AvgTps");
				apiMetrics.MinRt = _ctx.FloatValue("GetPtsReportDetails.ApiMetricsList["+ i +"].MinRt");
				apiMetrics.Seg99Rt = _ctx.FloatValue("GetPtsReportDetails.ApiMetricsList["+ i +"].Seg99Rt");
				apiMetrics.Seg50Rt = _ctx.FloatValue("GetPtsReportDetails.ApiMetricsList["+ i +"].Seg50Rt");
				apiMetrics.MaxRt = _ctx.FloatValue("GetPtsReportDetails.ApiMetricsList["+ i +"].MaxRt");
				apiMetrics.Seg90Rt = _ctx.FloatValue("GetPtsReportDetails.ApiMetricsList["+ i +"].Seg90Rt");
				apiMetrics.SuccessRateBiz = _ctx.FloatValue("GetPtsReportDetails.ApiMetricsList["+ i +"].SuccessRateBiz");
				apiMetrics.AvgRt = _ctx.FloatValue("GetPtsReportDetails.ApiMetricsList["+ i +"].AvgRt");
				apiMetrics.FailCountReq = _ctx.LongValue("GetPtsReportDetails.ApiMetricsList["+ i +"].FailCountReq");
				apiMetrics.SuccessRateReq = _ctx.FloatValue("GetPtsReportDetails.ApiMetricsList["+ i +"].SuccessRateReq");
				apiMetrics.ApiName = _ctx.StringValue("GetPtsReportDetails.ApiMetricsList["+ i +"].ApiName");

				getPtsReportDetailsResponse_apiMetricsList.Add(apiMetrics);
			}
			getPtsReportDetailsResponse.ApiMetricsList = getPtsReportDetailsResponse_apiMetricsList;
        
			return getPtsReportDetailsResponse;
        }
    }
}
