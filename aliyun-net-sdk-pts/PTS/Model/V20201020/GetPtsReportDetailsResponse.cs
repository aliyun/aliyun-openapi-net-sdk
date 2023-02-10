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
	public class GetPtsReportDetailsResponse : AcsResponse
	{

		private string message;

		private string requestId;

		private int? httpStatusCode;

		private string code;

		private bool? success;

		private List<GetPtsReportDetails_ApiMetrics> apiMetricsList;

		private GetPtsReportDetails_ReportOverView reportOverView;

		private GetPtsReportDetails_SceneMetrics sceneMetrics;

		private GetPtsReportDetails_SceneSnapShot sceneSnapShot;

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

		public List<GetPtsReportDetails_ApiMetrics> ApiMetricsList
		{
			get
			{
				return apiMetricsList;
			}
			set	
			{
				apiMetricsList = value;
			}
		}

		public GetPtsReportDetails_ReportOverView ReportOverView
		{
			get
			{
				return reportOverView;
			}
			set	
			{
				reportOverView = value;
			}
		}

		public GetPtsReportDetails_SceneMetrics SceneMetrics
		{
			get
			{
				return sceneMetrics;
			}
			set	
			{
				sceneMetrics = value;
			}
		}

		public GetPtsReportDetails_SceneSnapShot SceneSnapShot
		{
			get
			{
				return sceneSnapShot;
			}
			set	
			{
				sceneSnapShot = value;
			}
		}

		public class GetPtsReportDetails_ApiMetrics
		{

			private long? failCountBiz;

			private float? seg75Rt;

			private long? allCount;

			private float? avgTps;

			private float? minRt;

			private float? seg99Rt;

			private float? seg50Rt;

			private float? maxRt;

			private float? seg90Rt;

			private float? successRateBiz;

			private float? avgRt;

			private long? failCountReq;

			private float? successRateReq;

			private string apiName;

			public long? FailCountBiz
			{
				get
				{
					return failCountBiz;
				}
				set	
				{
					failCountBiz = value;
				}
			}

			public float? Seg75Rt
			{
				get
				{
					return seg75Rt;
				}
				set	
				{
					seg75Rt = value;
				}
			}

			public long? AllCount
			{
				get
				{
					return allCount;
				}
				set	
				{
					allCount = value;
				}
			}

			public float? AvgTps
			{
				get
				{
					return avgTps;
				}
				set	
				{
					avgTps = value;
				}
			}

			public float? MinRt
			{
				get
				{
					return minRt;
				}
				set	
				{
					minRt = value;
				}
			}

			public float? Seg99Rt
			{
				get
				{
					return seg99Rt;
				}
				set	
				{
					seg99Rt = value;
				}
			}

			public float? Seg50Rt
			{
				get
				{
					return seg50Rt;
				}
				set	
				{
					seg50Rt = value;
				}
			}

			public float? MaxRt
			{
				get
				{
					return maxRt;
				}
				set	
				{
					maxRt = value;
				}
			}

			public float? Seg90Rt
			{
				get
				{
					return seg90Rt;
				}
				set	
				{
					seg90Rt = value;
				}
			}

			public float? SuccessRateBiz
			{
				get
				{
					return successRateBiz;
				}
				set	
				{
					successRateBiz = value;
				}
			}

			public float? AvgRt
			{
				get
				{
					return avgRt;
				}
				set	
				{
					avgRt = value;
				}
			}

			public long? FailCountReq
			{
				get
				{
					return failCountReq;
				}
				set	
				{
					failCountReq = value;
				}
			}

			public float? SuccessRateReq
			{
				get
				{
					return successRateReq;
				}
				set	
				{
					successRateReq = value;
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
		}

		public class GetPtsReportDetails_ReportOverView
		{

			private string reportName;

			private string endTime;

			private string startTime;

			private int? agentCount;

			private string reportId;

			private long? vum;

			public string ReportName
			{
				get
				{
					return reportName;
				}
				set	
				{
					reportName = value;
				}
			}

			public string EndTime
			{
				get
				{
					return endTime;
				}
				set	
				{
					endTime = value;
				}
			}

			public string StartTime
			{
				get
				{
					return startTime;
				}
				set	
				{
					startTime = value;
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

			public string ReportId
			{
				get
				{
					return reportId;
				}
				set	
				{
					reportId = value;
				}
			}

			public long? Vum
			{
				get
				{
					return vum;
				}
				set	
				{
					vum = value;
				}
			}
		}

		public class GetPtsReportDetails_SceneMetrics
		{

			private long? failCountBiz;

			private long? allCount;

			private float? successRateBiz;

			private float? avgRt;

			private long? failCountReq;

			private float? avgTps;

			private float? seg99Rt;

			private float? successRateReq;

			private float? seg90Rt;

			public long? FailCountBiz
			{
				get
				{
					return failCountBiz;
				}
				set	
				{
					failCountBiz = value;
				}
			}

			public long? AllCount
			{
				get
				{
					return allCount;
				}
				set	
				{
					allCount = value;
				}
			}

			public float? SuccessRateBiz
			{
				get
				{
					return successRateBiz;
				}
				set	
				{
					successRateBiz = value;
				}
			}

			public float? AvgRt
			{
				get
				{
					return avgRt;
				}
				set	
				{
					avgRt = value;
				}
			}

			public long? FailCountReq
			{
				get
				{
					return failCountReq;
				}
				set	
				{
					failCountReq = value;
				}
			}

			public float? AvgTps
			{
				get
				{
					return avgTps;
				}
				set	
				{
					avgTps = value;
				}
			}

			public float? Seg99Rt
			{
				get
				{
					return seg99Rt;
				}
				set	
				{
					seg99Rt = value;
				}
			}

			public float? SuccessRateReq
			{
				get
				{
					return successRateReq;
				}
				set	
				{
					successRateReq = value;
				}
			}

			public float? Seg90Rt
			{
				get
				{
					return seg90Rt;
				}
				set	
				{
					seg90Rt = value;
				}
			}
		}

		public class GetPtsReportDetails_SceneSnapShot
		{

			private string status;

			private string modifiedTime;

			private string createTime;

			private string sceneName;

			private string sceneId;

			private List<GetPtsReportDetails_FileParameter> fileParameterList;

			private List<GetPtsReportDetails_Relation> relationList;

			private List<GetPtsReportDetails_GlobalParameter> globalParameterList;

			private GetPtsReportDetails_LoadConfig loadConfig;

			private GetPtsReportDetails_AdvanceSetting advanceSetting;

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

			public List<GetPtsReportDetails_FileParameter> FileParameterList
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

			public List<GetPtsReportDetails_Relation> RelationList
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

			public List<GetPtsReportDetails_GlobalParameter> GlobalParameterList
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

			public GetPtsReportDetails_LoadConfig LoadConfig
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

			public GetPtsReportDetails_AdvanceSetting AdvanceSetting
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

			public class GetPtsReportDetails_FileParameter
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

			public class GetPtsReportDetails_Relation
			{

				private string relationName;

				private string relationId;

				private List<GetPtsReportDetails_FileParameterExplain> fileParameterExplainList;

				private List<GetPtsReportDetails_Api> apiList;

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

				public List<GetPtsReportDetails_FileParameterExplain> FileParameterExplainList
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

				public List<GetPtsReportDetails_Api> ApiList
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

				public class GetPtsReportDetails_FileParameterExplain
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

				public class GetPtsReportDetails_Api
				{

					private string apiId;

					private int? timeoutInSecond;

					private string url;

					private string method;

					private int? redirectCountLimit;

					private string apiName;

					private List<GetPtsReportDetails_CheckPoint> checkPointList;

					private List<GetPtsReportDetails_Header> headerList;

					private List<GetPtsReportDetails_Export> exportList;

					private GetPtsReportDetails_Body body;

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

					public List<GetPtsReportDetails_CheckPoint> CheckPointList
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

					public List<GetPtsReportDetails_Header> HeaderList
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

					public List<GetPtsReportDetails_Export> ExportList
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

					public GetPtsReportDetails_Body Body
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

					public class GetPtsReportDetails_CheckPoint
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

					public class GetPtsReportDetails_Header
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

					public class GetPtsReportDetails_Export
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

					public class GetPtsReportDetails_Body
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

			public class GetPtsReportDetails_GlobalParameter
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

			public class GetPtsReportDetails_LoadConfig
			{

				private int? maxRunningTime;

				private int? agentCount;

				private string testMode;

				private List<GetPtsReportDetails_ApiLoadConfig> apiLoadConfigList;

				private List<GetPtsReportDetails_RelationLoadConfig> relationLoadConfigList;

				private GetPtsReportDetails_Configuration configuration;

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

				public List<GetPtsReportDetails_ApiLoadConfig> ApiLoadConfigList
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

				public List<GetPtsReportDetails_RelationLoadConfig> RelationLoadConfigList
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

				public GetPtsReportDetails_Configuration Configuration
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

				public class GetPtsReportDetails_ApiLoadConfig
				{

					private int? rpsBegin;

					private int? rpsLimit;

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
				}

				public class GetPtsReportDetails_RelationLoadConfig
				{

					private int? concurrencyBegin;

					private int? concurrencyLimit;

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
				}

				public class GetPtsReportDetails_Configuration
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
			}

			public class GetPtsReportDetails_AdvanceSetting
			{

				private int? logRate;

				private int? connectionTimeoutInSecond;

				private string successCode;

				private List<GetPtsReportDetails_DomainBinding> domainBindingList;

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

				public List<GetPtsReportDetails_DomainBinding> DomainBindingList
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

				public class GetPtsReportDetails_DomainBinding
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
