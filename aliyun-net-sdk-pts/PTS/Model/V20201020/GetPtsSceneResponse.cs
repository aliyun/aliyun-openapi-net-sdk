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
using System.Collections.Generic;
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.PTS.Model.V20201020
{
	public class GetPtsSceneResponse : AcsResponse
	{

		private string message;

		private string requestId;

		private int? httpStatusCode;

		private string code;

		private bool? success;

		private GetPtsScene_Scene scene;

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public int? HttpStatusCode
		{
			get
			{
				return httpStatusCode;
			}
			set	
			{
				httpStatusCode = value;
			}
		}

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public GetPtsScene_Scene Scene
		{
			get
			{
				return scene;
			}
			set	
			{
				scene = value;
			}
		}

		public class GetPtsScene_Scene
		{

			private string status;

			private string modifiedTime;

			private string createTime;

			private string sceneName;

			private string sceneId;

			private List<GetPtsScene_FileParameter> fileParameterList;

			private List<GetPtsScene_Relation> relationList;

			private List<GetPtsScene_GlobalParameter> globalParameterList;

			private List<GetPtsScene_Header1> headers;

			private GetPtsScene_LoadConfig loadConfig;

			private GetPtsScene_AdvanceSetting advanceSetting;

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public string ModifiedTime
			{
				get
				{
					return modifiedTime;
				}
				set	
				{
					modifiedTime = value;
				}
			}

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public string SceneName
			{
				get
				{
					return sceneName;
				}
				set	
				{
					sceneName = value;
				}
			}

			public string SceneId
			{
				get
				{
					return sceneId;
				}
				set	
				{
					sceneId = value;
				}
			}

			public List<GetPtsScene_FileParameter> FileParameterList
			{
				get
				{
					return fileParameterList;
				}
				set	
				{
					fileParameterList = value;
				}
			}

			public List<GetPtsScene_Relation> RelationList
			{
				get
				{
					return relationList;
				}
				set	
				{
					relationList = value;
				}
			}

			public List<GetPtsScene_GlobalParameter> GlobalParameterList
			{
				get
				{
					return globalParameterList;
				}
				set	
				{
					globalParameterList = value;
				}
			}

			public List<GetPtsScene_Header1> Headers
			{
				get
				{
					return headers;
				}
				set	
				{
					headers = value;
				}
			}

			public GetPtsScene_LoadConfig LoadConfig
			{
				get
				{
					return loadConfig;
				}
				set	
				{
					loadConfig = value;
				}
			}

			public GetPtsScene_AdvanceSetting AdvanceSetting
			{
				get
				{
					return advanceSetting;
				}
				set	
				{
					advanceSetting = value;
				}
			}

			public class GetPtsScene_FileParameter
			{

				private string fileOssAddress;

				private string fileName;

				public string FileOssAddress
				{
					get
					{
						return fileOssAddress;
					}
					set	
					{
						fileOssAddress = value;
					}
				}

				public string FileName
				{
					get
					{
						return fileName;
					}
					set	
					{
						fileName = value;
					}
				}
			}

			public class GetPtsScene_Relation
			{

				private string relationName;

				private string relationId;

				private List<GetPtsScene_FileParameterExplain> fileParameterExplainList;

				private List<GetPtsScene_Api> apiList;

				public string RelationName
				{
					get
					{
						return relationName;
					}
					set	
					{
						relationName = value;
					}
				}

				public string RelationId
				{
					get
					{
						return relationId;
					}
					set	
					{
						relationId = value;
					}
				}

				public List<GetPtsScene_FileParameterExplain> FileParameterExplainList
				{
					get
					{
						return fileParameterExplainList;
					}
					set	
					{
						fileParameterExplainList = value;
					}
				}

				public List<GetPtsScene_Api> ApiList
				{
					get
					{
						return apiList;
					}
					set	
					{
						apiList = value;
					}
				}

				public class GetPtsScene_FileParameterExplain
				{

					private bool? cycleOnce;

					private string fileParamName;

					private string fileName;

					private bool? baseFile;

					public bool? CycleOnce
					{
						get
						{
							return cycleOnce;
						}
						set	
						{
							cycleOnce = value;
						}
					}

					public string FileParamName
					{
						get
						{
							return fileParamName;
						}
						set	
						{
							fileParamName = value;
						}
					}

					public string FileName
					{
						get
						{
							return fileName;
						}
						set	
						{
							fileName = value;
						}
					}

					public bool? BaseFile
					{
						get
						{
							return baseFile;
						}
						set	
						{
							baseFile = value;
						}
					}
				}

				public class GetPtsScene_Api
				{

					private string apiId;

					private int? timeoutInSecond;

					private string url;

					private string method;

					private int? redirectCountLimit;

					private string apiName;

					private List<GetPtsScene_CheckPoint> checkPointList;

					private List<GetPtsScene_Header> headerList;

					private List<GetPtsScene_Export> exportList;

					private GetPtsScene_Body body;

					public string ApiId
					{
						get
						{
							return apiId;
						}
						set	
						{
							apiId = value;
						}
					}

					public int? TimeoutInSecond
					{
						get
						{
							return timeoutInSecond;
						}
						set	
						{
							timeoutInSecond = value;
						}
					}

					public string Url
					{
						get
						{
							return url;
						}
						set	
						{
							url = value;
						}
					}

					public string Method
					{
						get
						{
							return method;
						}
						set	
						{
							method = value;
						}
					}

					public int? RedirectCountLimit
					{
						get
						{
							return redirectCountLimit;
						}
						set	
						{
							redirectCountLimit = value;
						}
					}

					public string ApiName
					{
						get
						{
							return apiName;
						}
						set	
						{
							apiName = value;
						}
					}

					public List<GetPtsScene_CheckPoint> CheckPointList
					{
						get
						{
							return checkPointList;
						}
						set	
						{
							checkPointList = value;
						}
					}

					public List<GetPtsScene_Header> HeaderList
					{
						get
						{
							return headerList;
						}
						set	
						{
							headerList = value;
						}
					}

					public List<GetPtsScene_Export> ExportList
					{
						get
						{
							return exportList;
						}
						set	
						{
							exportList = value;
						}
					}

					public GetPtsScene_Body Body
					{
						get
						{
							return body;
						}
						set	
						{
							body = value;
						}
					}

					public class GetPtsScene_CheckPoint
					{

						private string checkType;

						private string _operator;

						private string expectValue;

						private string checkPoint;

						public string CheckType
						{
							get
							{
								return checkType;
							}
							set	
							{
								checkType = value;
							}
						}

						public string _Operator
						{
							get
							{
								return _operator;
							}
							set	
							{
								_operator = value;
							}
						}

						public string ExpectValue
						{
							get
							{
								return expectValue;
							}
							set	
							{
								expectValue = value;
							}
						}

						public string CheckPoint
						{
							get
							{
								return checkPoint;
							}
							set	
							{
								checkPoint = value;
							}
						}
					}

					public class GetPtsScene_Header
					{

						private string headerValue;

						private string headerName;

						public string HeaderValue
						{
							get
							{
								return headerValue;
							}
							set	
							{
								headerValue = value;
							}
						}

						public string HeaderName
						{
							get
							{
								return headerName;
							}
							set	
							{
								headerName = value;
							}
						}
					}

					public class GetPtsScene_Export
					{

						private string exportType;

						private string exportValue;

						private string exportName;

						private string count;

						public string ExportType
						{
							get
							{
								return exportType;
							}
							set	
							{
								exportType = value;
							}
						}

						public string ExportValue
						{
							get
							{
								return exportValue;
							}
							set	
							{
								exportValue = value;
							}
						}

						public string ExportName
						{
							get
							{
								return exportName;
							}
							set	
							{
								exportName = value;
							}
						}

						public string Count
						{
							get
							{
								return count;
							}
							set	
							{
								count = value;
							}
						}
					}

					public class GetPtsScene_Body
					{

						private string bodyValue;

						private string contentType;

						public string BodyValue
						{
							get
							{
								return bodyValue;
							}
							set	
							{
								bodyValue = value;
							}
						}

						public string ContentType
						{
							get
							{
								return contentType;
							}
							set	
							{
								contentType = value;
							}
						}
					}
				}
			}

			public class GetPtsScene_GlobalParameter
			{

				private string paramName;

				private string paramValue;

				public string ParamName
				{
					get
					{
						return paramName;
					}
					set	
					{
						paramName = value;
					}
				}

				public string ParamValue
				{
					get
					{
						return paramValue;
					}
					set	
					{
						paramValue = value;
					}
				}
			}

			public class GetPtsScene_Header1
			{

				private string name;

				private string _value;

				public string Name
				{
					get
					{
						return name;
					}
					set	
					{
						name = value;
					}
				}

				public string _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}
			}

			public class GetPtsScene_LoadConfig
			{

				private int? maxRunningTime;

				private int? agentCount;

				private string testMode;

				private bool? autoStep;

				private int? increment;

				private int? keepTime;

				private List<GetPtsScene_ApiLoadConfig> apiLoadConfigList;

				private List<GetPtsScene_RelationLoadConfig> relationLoadConfigList;

				private GetPtsScene_Configuration configuration;

				private GetPtsScene_VpcLoadConfig vpcLoadConfig;

				public int? MaxRunningTime
				{
					get
					{
						return maxRunningTime;
					}
					set	
					{
						maxRunningTime = value;
					}
				}

				public int? AgentCount
				{
					get
					{
						return agentCount;
					}
					set	
					{
						agentCount = value;
					}
				}

				public string TestMode
				{
					get
					{
						return testMode;
					}
					set	
					{
						testMode = value;
					}
				}

				public bool? AutoStep
				{
					get
					{
						return autoStep;
					}
					set	
					{
						autoStep = value;
					}
				}

				public int? Increment
				{
					get
					{
						return increment;
					}
					set	
					{
						increment = value;
					}
				}

				public int? KeepTime
				{
					get
					{
						return keepTime;
					}
					set	
					{
						keepTime = value;
					}
				}

				public List<GetPtsScene_ApiLoadConfig> ApiLoadConfigList
				{
					get
					{
						return apiLoadConfigList;
					}
					set	
					{
						apiLoadConfigList = value;
					}
				}

				public List<GetPtsScene_RelationLoadConfig> RelationLoadConfigList
				{
					get
					{
						return relationLoadConfigList;
					}
					set	
					{
						relationLoadConfigList = value;
					}
				}

				public GetPtsScene_Configuration Configuration
				{
					get
					{
						return configuration;
					}
					set	
					{
						configuration = value;
					}
				}

				public GetPtsScene_VpcLoadConfig VpcLoadConfig
				{
					get
					{
						return vpcLoadConfig;
					}
					set	
					{
						vpcLoadConfig = value;
					}
				}

				public class GetPtsScene_ApiLoadConfig
				{

					private int? rpsBegin;

					private int? rpsLimit;

					private string apiId;

					public int? RpsBegin
					{
						get
						{
							return rpsBegin;
						}
						set	
						{
							rpsBegin = value;
						}
					}

					public int? RpsLimit
					{
						get
						{
							return rpsLimit;
						}
						set	
						{
							rpsLimit = value;
						}
					}

					public string ApiId
					{
						get
						{
							return apiId;
						}
						set	
						{
							apiId = value;
						}
					}
				}

				public class GetPtsScene_RelationLoadConfig
				{

					private int? concurrencyBegin;

					private int? concurrencyLimit;

					private string relationId;

					public int? ConcurrencyBegin
					{
						get
						{
							return concurrencyBegin;
						}
						set	
						{
							concurrencyBegin = value;
						}
					}

					public int? ConcurrencyLimit
					{
						get
						{
							return concurrencyLimit;
						}
						set	
						{
							concurrencyLimit = value;
						}
					}

					public string RelationId
					{
						get
						{
							return relationId;
						}
						set	
						{
							relationId = value;
						}
					}
				}

				public class GetPtsScene_Configuration
				{

					private int? allRpsBegin;

					private int? allConcurrencyBegin;

					private int? allConcurrencyLimit;

					private int? allRpsLimit;

					public int? AllRpsBegin
					{
						get
						{
							return allRpsBegin;
						}
						set	
						{
							allRpsBegin = value;
						}
					}

					public int? AllConcurrencyBegin
					{
						get
						{
							return allConcurrencyBegin;
						}
						set	
						{
							allConcurrencyBegin = value;
						}
					}

					public int? AllConcurrencyLimit
					{
						get
						{
							return allConcurrencyLimit;
						}
						set	
						{
							allConcurrencyLimit = value;
						}
					}

					public int? AllRpsLimit
					{
						get
						{
							return allRpsLimit;
						}
						set	
						{
							allRpsLimit = value;
						}
					}
				}

				public class GetPtsScene_VpcLoadConfig
				{

					private string vpcId;

					private string vSwitchId;

					private string securityGroupId;

					private string regionId;

					public string VpcId
					{
						get
						{
							return vpcId;
						}
						set	
						{
							vpcId = value;
						}
					}

					public string VSwitchId
					{
						get
						{
							return vSwitchId;
						}
						set	
						{
							vSwitchId = value;
						}
					}

					public string SecurityGroupId
					{
						get
						{
							return securityGroupId;
						}
						set	
						{
							securityGroupId = value;
						}
					}

					public string RegionId
					{
						get
						{
							return regionId;
						}
						set	
						{
							regionId = value;
						}
					}
				}
			}

			public class GetPtsScene_AdvanceSetting
			{

				private int? logRate;

				private int? connectionTimeoutInSecond;

				private string successCode;

				private List<GetPtsScene_DomainBinding> domainBindingList;

				public int? LogRate
				{
					get
					{
						return logRate;
					}
					set	
					{
						logRate = value;
					}
				}

				public int? ConnectionTimeoutInSecond
				{
					get
					{
						return connectionTimeoutInSecond;
					}
					set	
					{
						connectionTimeoutInSecond = value;
					}
				}

				public string SuccessCode
				{
					get
					{
						return successCode;
					}
					set	
					{
						successCode = value;
					}
				}

				public List<GetPtsScene_DomainBinding> DomainBindingList
				{
					get
					{
						return domainBindingList;
					}
					set	
					{
						domainBindingList = value;
					}
				}

				public class GetPtsScene_DomainBinding
				{

					private string domain;

					private List<string> ips;

					public string Domain
					{
						get
						{
							return domain;
						}
						set	
						{
							domain = value;
						}
					}

					public List<string> Ips
					{
						get
						{
							return ips;
						}
						set	
						{
							ips = value;
						}
					}
				}
			}
		}
	}
}
