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
    public class GetPtsSceneResponseUnmarshaller
    {
        public static GetPtsSceneResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetPtsSceneResponse getPtsSceneResponse = new GetPtsSceneResponse();

			getPtsSceneResponse.HttpResponse = _ctx.HttpResponse;
			getPtsSceneResponse.Message = _ctx.StringValue("GetPtsScene.Message");
			getPtsSceneResponse.RequestId = _ctx.StringValue("GetPtsScene.RequestId");
			getPtsSceneResponse.HttpStatusCode = _ctx.IntegerValue("GetPtsScene.HttpStatusCode");
			getPtsSceneResponse.Code = _ctx.StringValue("GetPtsScene.Code");
			getPtsSceneResponse.Success = _ctx.BooleanValue("GetPtsScene.Success");

			GetPtsSceneResponse.GetPtsScene_Scene scene = new GetPtsSceneResponse.GetPtsScene_Scene();
			scene.Status = _ctx.StringValue("GetPtsScene.Scene.Status");
			scene.ModifiedTime = _ctx.StringValue("GetPtsScene.Scene.ModifiedTime");
			scene.CreateTime = _ctx.StringValue("GetPtsScene.Scene.CreateTime");
			scene.SceneName = _ctx.StringValue("GetPtsScene.Scene.SceneName");
			scene.SceneId = _ctx.StringValue("GetPtsScene.Scene.SceneId");

			GetPtsSceneResponse.GetPtsScene_Scene.GetPtsScene_LoadConfig loadConfig = new GetPtsSceneResponse.GetPtsScene_Scene.GetPtsScene_LoadConfig();
			loadConfig.MaxRunningTime = _ctx.IntegerValue("GetPtsScene.Scene.LoadConfig.MaxRunningTime");
			loadConfig.AgentCount = _ctx.IntegerValue("GetPtsScene.Scene.LoadConfig.AgentCount");
			loadConfig.TestMode = _ctx.StringValue("GetPtsScene.Scene.LoadConfig.TestMode");
			loadConfig.AutoStep = _ctx.BooleanValue("GetPtsScene.Scene.LoadConfig.AutoStep");
			loadConfig.Increment = _ctx.IntegerValue("GetPtsScene.Scene.LoadConfig.Increment");
			loadConfig.KeepTime = _ctx.IntegerValue("GetPtsScene.Scene.LoadConfig.KeepTime");

			GetPtsSceneResponse.GetPtsScene_Scene.GetPtsScene_LoadConfig.GetPtsScene_Configuration configuration = new GetPtsSceneResponse.GetPtsScene_Scene.GetPtsScene_LoadConfig.GetPtsScene_Configuration();
			configuration.AllRpsBegin = _ctx.IntegerValue("GetPtsScene.Scene.LoadConfig.Configuration.AllRpsBegin");
			configuration.AllConcurrencyBegin = _ctx.IntegerValue("GetPtsScene.Scene.LoadConfig.Configuration.AllConcurrencyBegin");
			configuration.AllConcurrencyLimit = _ctx.IntegerValue("GetPtsScene.Scene.LoadConfig.Configuration.AllConcurrencyLimit");
			configuration.AllRpsLimit = _ctx.IntegerValue("GetPtsScene.Scene.LoadConfig.Configuration.AllRpsLimit");
			loadConfig.Configuration = configuration;

			GetPtsSceneResponse.GetPtsScene_Scene.GetPtsScene_LoadConfig.GetPtsScene_VpcLoadConfig vpcLoadConfig = new GetPtsSceneResponse.GetPtsScene_Scene.GetPtsScene_LoadConfig.GetPtsScene_VpcLoadConfig();
			vpcLoadConfig.VpcId = _ctx.StringValue("GetPtsScene.Scene.LoadConfig.VpcLoadConfig.VpcId");
			vpcLoadConfig.VSwitchId = _ctx.StringValue("GetPtsScene.Scene.LoadConfig.VpcLoadConfig.VSwitchId");
			vpcLoadConfig.SecurityGroupId = _ctx.StringValue("GetPtsScene.Scene.LoadConfig.VpcLoadConfig.SecurityGroupId");
			vpcLoadConfig.RegionId = _ctx.StringValue("GetPtsScene.Scene.LoadConfig.VpcLoadConfig.RegionId");
			loadConfig.VpcLoadConfig = vpcLoadConfig;

			List<GetPtsSceneResponse.GetPtsScene_Scene.GetPtsScene_LoadConfig.GetPtsScene_ApiLoadConfig> loadConfig_apiLoadConfigList = new List<GetPtsSceneResponse.GetPtsScene_Scene.GetPtsScene_LoadConfig.GetPtsScene_ApiLoadConfig>();
			for (int i = 0; i < _ctx.Length("GetPtsScene.Scene.LoadConfig.ApiLoadConfigList.Length"); i++) {
				GetPtsSceneResponse.GetPtsScene_Scene.GetPtsScene_LoadConfig.GetPtsScene_ApiLoadConfig apiLoadConfig = new GetPtsSceneResponse.GetPtsScene_Scene.GetPtsScene_LoadConfig.GetPtsScene_ApiLoadConfig();
				apiLoadConfig.RpsBegin = _ctx.IntegerValue("GetPtsScene.Scene.LoadConfig.ApiLoadConfigList["+ i +"].RpsBegin");
				apiLoadConfig.RpsLimit = _ctx.IntegerValue("GetPtsScene.Scene.LoadConfig.ApiLoadConfigList["+ i +"].RpsLimit");
				apiLoadConfig.ApiId = _ctx.StringValue("GetPtsScene.Scene.LoadConfig.ApiLoadConfigList["+ i +"].ApiId");

				loadConfig_apiLoadConfigList.Add(apiLoadConfig);
			}
			loadConfig.ApiLoadConfigList = loadConfig_apiLoadConfigList;

			List<GetPtsSceneResponse.GetPtsScene_Scene.GetPtsScene_LoadConfig.GetPtsScene_RelationLoadConfig> loadConfig_relationLoadConfigList = new List<GetPtsSceneResponse.GetPtsScene_Scene.GetPtsScene_LoadConfig.GetPtsScene_RelationLoadConfig>();
			for (int i = 0; i < _ctx.Length("GetPtsScene.Scene.LoadConfig.RelationLoadConfigList.Length"); i++) {
				GetPtsSceneResponse.GetPtsScene_Scene.GetPtsScene_LoadConfig.GetPtsScene_RelationLoadConfig relationLoadConfig = new GetPtsSceneResponse.GetPtsScene_Scene.GetPtsScene_LoadConfig.GetPtsScene_RelationLoadConfig();
				relationLoadConfig.ConcurrencyBegin = _ctx.IntegerValue("GetPtsScene.Scene.LoadConfig.RelationLoadConfigList["+ i +"].ConcurrencyBegin");
				relationLoadConfig.ConcurrencyLimit = _ctx.IntegerValue("GetPtsScene.Scene.LoadConfig.RelationLoadConfigList["+ i +"].ConcurrencyLimit");
				relationLoadConfig.RelationId = _ctx.StringValue("GetPtsScene.Scene.LoadConfig.RelationLoadConfigList["+ i +"].RelationId");

				loadConfig_relationLoadConfigList.Add(relationLoadConfig);
			}
			loadConfig.RelationLoadConfigList = loadConfig_relationLoadConfigList;
			scene.LoadConfig = loadConfig;

			GetPtsSceneResponse.GetPtsScene_Scene.GetPtsScene_AdvanceSetting advanceSetting = new GetPtsSceneResponse.GetPtsScene_Scene.GetPtsScene_AdvanceSetting();
			advanceSetting.LogRate = _ctx.IntegerValue("GetPtsScene.Scene.AdvanceSetting.LogRate");
			advanceSetting.ConnectionTimeoutInSecond = _ctx.IntegerValue("GetPtsScene.Scene.AdvanceSetting.ConnectionTimeoutInSecond");
			advanceSetting.SuccessCode = _ctx.StringValue("GetPtsScene.Scene.AdvanceSetting.SuccessCode");

			List<GetPtsSceneResponse.GetPtsScene_Scene.GetPtsScene_AdvanceSetting.GetPtsScene_DomainBinding> advanceSetting_domainBindingList = new List<GetPtsSceneResponse.GetPtsScene_Scene.GetPtsScene_AdvanceSetting.GetPtsScene_DomainBinding>();
			for (int i = 0; i < _ctx.Length("GetPtsScene.Scene.AdvanceSetting.DomainBindingList.Length"); i++) {
				GetPtsSceneResponse.GetPtsScene_Scene.GetPtsScene_AdvanceSetting.GetPtsScene_DomainBinding domainBinding = new GetPtsSceneResponse.GetPtsScene_Scene.GetPtsScene_AdvanceSetting.GetPtsScene_DomainBinding();
				domainBinding.Domain = _ctx.StringValue("GetPtsScene.Scene.AdvanceSetting.DomainBindingList["+ i +"].Domain");

				List<string> domainBinding_ips = new List<string>();
				for (int j = 0; j < _ctx.Length("GetPtsScene.Scene.AdvanceSetting.DomainBindingList["+ i +"].Ips.Length"); j++) {
					domainBinding_ips.Add(_ctx.StringValue("GetPtsScene.Scene.AdvanceSetting.DomainBindingList["+ i +"].Ips["+ j +"]"));
				}
				domainBinding.Ips = domainBinding_ips;

				advanceSetting_domainBindingList.Add(domainBinding);
			}
			advanceSetting.DomainBindingList = advanceSetting_domainBindingList;
			scene.AdvanceSetting = advanceSetting;

			List<GetPtsSceneResponse.GetPtsScene_Scene.GetPtsScene_FileParameter> scene_fileParameterList = new List<GetPtsSceneResponse.GetPtsScene_Scene.GetPtsScene_FileParameter>();
			for (int i = 0; i < _ctx.Length("GetPtsScene.Scene.FileParameterList.Length"); i++) {
				GetPtsSceneResponse.GetPtsScene_Scene.GetPtsScene_FileParameter fileParameter = new GetPtsSceneResponse.GetPtsScene_Scene.GetPtsScene_FileParameter();
				fileParameter.FileOssAddress = _ctx.StringValue("GetPtsScene.Scene.FileParameterList["+ i +"].FileOssAddress");
				fileParameter.FileName = _ctx.StringValue("GetPtsScene.Scene.FileParameterList["+ i +"].FileName");

				scene_fileParameterList.Add(fileParameter);
			}
			scene.FileParameterList = scene_fileParameterList;

			List<GetPtsSceneResponse.GetPtsScene_Scene.GetPtsScene_Relation> scene_relationList = new List<GetPtsSceneResponse.GetPtsScene_Scene.GetPtsScene_Relation>();
			for (int i = 0; i < _ctx.Length("GetPtsScene.Scene.RelationList.Length"); i++) {
				GetPtsSceneResponse.GetPtsScene_Scene.GetPtsScene_Relation relation = new GetPtsSceneResponse.GetPtsScene_Scene.GetPtsScene_Relation();
				relation.RelationName = _ctx.StringValue("GetPtsScene.Scene.RelationList["+ i +"].RelationName");
				relation.RelationId = _ctx.StringValue("GetPtsScene.Scene.RelationList["+ i +"].RelationId");

				List<GetPtsSceneResponse.GetPtsScene_Scene.GetPtsScene_Relation.GetPtsScene_FileParameterExplain> relation_fileParameterExplainList = new List<GetPtsSceneResponse.GetPtsScene_Scene.GetPtsScene_Relation.GetPtsScene_FileParameterExplain>();
				for (int j = 0; j < _ctx.Length("GetPtsScene.Scene.RelationList["+ i +"].FileParameterExplainList.Length"); j++) {
					GetPtsSceneResponse.GetPtsScene_Scene.GetPtsScene_Relation.GetPtsScene_FileParameterExplain fileParameterExplain = new GetPtsSceneResponse.GetPtsScene_Scene.GetPtsScene_Relation.GetPtsScene_FileParameterExplain();
					fileParameterExplain.CycleOnce = _ctx.BooleanValue("GetPtsScene.Scene.RelationList["+ i +"].FileParameterExplainList["+ j +"].CycleOnce");
					fileParameterExplain.FileParamName = _ctx.StringValue("GetPtsScene.Scene.RelationList["+ i +"].FileParameterExplainList["+ j +"].FileParamName");
					fileParameterExplain.FileName = _ctx.StringValue("GetPtsScene.Scene.RelationList["+ i +"].FileParameterExplainList["+ j +"].FileName");
					fileParameterExplain.BaseFile = _ctx.BooleanValue("GetPtsScene.Scene.RelationList["+ i +"].FileParameterExplainList["+ j +"].BaseFile");

					relation_fileParameterExplainList.Add(fileParameterExplain);
				}
				relation.FileParameterExplainList = relation_fileParameterExplainList;

				List<GetPtsSceneResponse.GetPtsScene_Scene.GetPtsScene_Relation.GetPtsScene_Api> relation_apiList = new List<GetPtsSceneResponse.GetPtsScene_Scene.GetPtsScene_Relation.GetPtsScene_Api>();
				for (int j = 0; j < _ctx.Length("GetPtsScene.Scene.RelationList["+ i +"].ApiList.Length"); j++) {
					GetPtsSceneResponse.GetPtsScene_Scene.GetPtsScene_Relation.GetPtsScene_Api api = new GetPtsSceneResponse.GetPtsScene_Scene.GetPtsScene_Relation.GetPtsScene_Api();
					api.ApiId = _ctx.StringValue("GetPtsScene.Scene.RelationList["+ i +"].ApiList["+ j +"].ApiId");
					api.TimeoutInSecond = _ctx.IntegerValue("GetPtsScene.Scene.RelationList["+ i +"].ApiList["+ j +"].TimeoutInSecond");
					api.Url = _ctx.StringValue("GetPtsScene.Scene.RelationList["+ i +"].ApiList["+ j +"].Url");
					api.Method = _ctx.StringValue("GetPtsScene.Scene.RelationList["+ i +"].ApiList["+ j +"].Method");
					api.RedirectCountLimit = _ctx.IntegerValue("GetPtsScene.Scene.RelationList["+ i +"].ApiList["+ j +"].RedirectCountLimit");
					api.ApiName = _ctx.StringValue("GetPtsScene.Scene.RelationList["+ i +"].ApiList["+ j +"].ApiName");

					GetPtsSceneResponse.GetPtsScene_Scene.GetPtsScene_Relation.GetPtsScene_Api.GetPtsScene_Body body = new GetPtsSceneResponse.GetPtsScene_Scene.GetPtsScene_Relation.GetPtsScene_Api.GetPtsScene_Body();
					body.BodyValue = _ctx.StringValue("GetPtsScene.Scene.RelationList["+ i +"].ApiList["+ j +"].Body.BodyValue");
					body.ContentType = _ctx.StringValue("GetPtsScene.Scene.RelationList["+ i +"].ApiList["+ j +"].Body.ContentType");
					api.Body = body;

					List<GetPtsSceneResponse.GetPtsScene_Scene.GetPtsScene_Relation.GetPtsScene_Api.GetPtsScene_CheckPoint> api_checkPointList = new List<GetPtsSceneResponse.GetPtsScene_Scene.GetPtsScene_Relation.GetPtsScene_Api.GetPtsScene_CheckPoint>();
					for (int k = 0; k < _ctx.Length("GetPtsScene.Scene.RelationList["+ i +"].ApiList["+ j +"].CheckPointList.Length"); k++) {
						GetPtsSceneResponse.GetPtsScene_Scene.GetPtsScene_Relation.GetPtsScene_Api.GetPtsScene_CheckPoint checkPoint = new GetPtsSceneResponse.GetPtsScene_Scene.GetPtsScene_Relation.GetPtsScene_Api.GetPtsScene_CheckPoint();
						checkPoint.CheckType = _ctx.StringValue("GetPtsScene.Scene.RelationList["+ i +"].ApiList["+ j +"].CheckPointList["+ k +"].CheckType");
						checkPoint._Operator = _ctx.StringValue("GetPtsScene.Scene.RelationList["+ i +"].ApiList["+ j +"].CheckPointList["+ k +"].Operator");
						checkPoint.ExpectValue = _ctx.StringValue("GetPtsScene.Scene.RelationList["+ i +"].ApiList["+ j +"].CheckPointList["+ k +"].ExpectValue");
						checkPoint.CheckPoint = _ctx.StringValue("GetPtsScene.Scene.RelationList["+ i +"].ApiList["+ j +"].CheckPointList["+ k +"].CheckPoint");

						api_checkPointList.Add(checkPoint);
					}
					api.CheckPointList = api_checkPointList;

					List<GetPtsSceneResponse.GetPtsScene_Scene.GetPtsScene_Relation.GetPtsScene_Api.GetPtsScene_Header> api_headerList = new List<GetPtsSceneResponse.GetPtsScene_Scene.GetPtsScene_Relation.GetPtsScene_Api.GetPtsScene_Header>();
					for (int k = 0; k < _ctx.Length("GetPtsScene.Scene.RelationList["+ i +"].ApiList["+ j +"].HeaderList.Length"); k++) {
						GetPtsSceneResponse.GetPtsScene_Scene.GetPtsScene_Relation.GetPtsScene_Api.GetPtsScene_Header header = new GetPtsSceneResponse.GetPtsScene_Scene.GetPtsScene_Relation.GetPtsScene_Api.GetPtsScene_Header();
						header.HeaderValue = _ctx.StringValue("GetPtsScene.Scene.RelationList["+ i +"].ApiList["+ j +"].HeaderList["+ k +"].HeaderValue");
						header.HeaderName = _ctx.StringValue("GetPtsScene.Scene.RelationList["+ i +"].ApiList["+ j +"].HeaderList["+ k +"].HeaderName");

						api_headerList.Add(header);
					}
					api.HeaderList = api_headerList;

					List<GetPtsSceneResponse.GetPtsScene_Scene.GetPtsScene_Relation.GetPtsScene_Api.GetPtsScene_Export> api_exportList = new List<GetPtsSceneResponse.GetPtsScene_Scene.GetPtsScene_Relation.GetPtsScene_Api.GetPtsScene_Export>();
					for (int k = 0; k < _ctx.Length("GetPtsScene.Scene.RelationList["+ i +"].ApiList["+ j +"].ExportList.Length"); k++) {
						GetPtsSceneResponse.GetPtsScene_Scene.GetPtsScene_Relation.GetPtsScene_Api.GetPtsScene_Export export = new GetPtsSceneResponse.GetPtsScene_Scene.GetPtsScene_Relation.GetPtsScene_Api.GetPtsScene_Export();
						export.ExportType = _ctx.StringValue("GetPtsScene.Scene.RelationList["+ i +"].ApiList["+ j +"].ExportList["+ k +"].ExportType");
						export.ExportValue = _ctx.StringValue("GetPtsScene.Scene.RelationList["+ i +"].ApiList["+ j +"].ExportList["+ k +"].ExportValue");
						export.ExportName = _ctx.StringValue("GetPtsScene.Scene.RelationList["+ i +"].ApiList["+ j +"].ExportList["+ k +"].ExportName");
						export.Count = _ctx.StringValue("GetPtsScene.Scene.RelationList["+ i +"].ApiList["+ j +"].ExportList["+ k +"].Count");

						api_exportList.Add(export);
					}
					api.ExportList = api_exportList;

					relation_apiList.Add(api);
				}
				relation.ApiList = relation_apiList;

				scene_relationList.Add(relation);
			}
			scene.RelationList = scene_relationList;

			List<GetPtsSceneResponse.GetPtsScene_Scene.GetPtsScene_GlobalParameter> scene_globalParameterList = new List<GetPtsSceneResponse.GetPtsScene_Scene.GetPtsScene_GlobalParameter>();
			for (int i = 0; i < _ctx.Length("GetPtsScene.Scene.GlobalParameterList.Length"); i++) {
				GetPtsSceneResponse.GetPtsScene_Scene.GetPtsScene_GlobalParameter globalParameter = new GetPtsSceneResponse.GetPtsScene_Scene.GetPtsScene_GlobalParameter();
				globalParameter.ParamName = _ctx.StringValue("GetPtsScene.Scene.GlobalParameterList["+ i +"].ParamName");
				globalParameter.ParamValue = _ctx.StringValue("GetPtsScene.Scene.GlobalParameterList["+ i +"].ParamValue");

				scene_globalParameterList.Add(globalParameter);
			}
			scene.GlobalParameterList = scene_globalParameterList;
			getPtsSceneResponse.Scene = scene;
        
			return getPtsSceneResponse;
        }
    }
}
