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
	public class GetPtsSceneBaseLineResponse : AcsResponse
	{

		private string sceneId;

		private string requestId;

		private string message;

		private int? httpStatusCode;

		private string code;

		private bool? success;

		private GetPtsSceneBaseLine_Baseline baseline;

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

		public GetPtsSceneBaseLine_Baseline Baseline
		{
			get
			{
				return baseline;
			}
			set	
			{
				baseline = value;
			}
		}

		public class GetPtsSceneBaseLine_Baseline
		{

			private string name;

			private List<GetPtsSceneBaseLine_ChainBaselineData> apiBaselines;

			private GetPtsSceneBaseLine_SceneBaseline sceneBaseline;

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

			public List<GetPtsSceneBaseLine_ChainBaselineData> ApiBaselines
			{
				get
				{
					return apiBaselines;
				}
				set	
				{
					apiBaselines = value;
				}
			}

			public GetPtsSceneBaseLine_SceneBaseline SceneBaseline
			{
				get
				{
					return sceneBaseline;
				}
				set	
				{
					sceneBaseline = value;
				}
			}

			public class GetPtsSceneBaseLine_ChainBaselineData
			{

				private long? failCountBiz;

				private float? avgTps;

				private int? minRt;

				private float? seg99Rt;

				private int? maxRt;

				private float? seg90Rt;

				private float? successRateBiz;

				private float? avgRt;

				private long? failCountReq;

				private string name;

				private float? successRateReq;

				private long? id;

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

				public int? MinRt
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

				public int? MaxRt
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

				public long? Id
				{
					get
					{
						return id;
					}
					set	
					{
						id = value;
					}
				}
			}

			public class GetPtsSceneBaseLine_SceneBaseline
			{

				private long? failCountBiz;

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
		}
	}
}
