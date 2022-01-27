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

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.foas.Transform;
using Aliyun.Acs.foas.Transform.V20181111;

namespace Aliyun.Acs.foas.Model.V20181111
{
    public class CommitJobRequest : RoaAcsRequest<CommitJobResponse>
    {
        public CommitJobRequest()
            : base("foas", "2018-11-11", "CommitJob", "foas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.foas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.foas.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			UriPattern = "/api/v2/projects/[projectName]/jobs/[jobName]/commit";
			Method = MethodType.PUT;
        }

		private string projectName;

		private bool? recommendOnly;

		private string suspendPeriods;

		private float? maxCU;

		private string configure;

		private bool? isOnOff;

		private string jobName;

		private List<SuspendPeriodParam> suspendPeriodParams = new List<SuspendPeriodParam>(){ };

		public string ProjectName
		{
			get
			{
				return projectName;
			}
			set	
			{
				projectName = value;
				DictionaryUtil.Add(PathParameters, "projectName", value);
			}
		}

		public bool? RecommendOnly
		{
			get
			{
				return recommendOnly;
			}
			set	
			{
				recommendOnly = value;
				DictionaryUtil.Add(BodyParameters, "recommendOnly", value.ToString());
			}
		}

		public string SuspendPeriods
		{
			get
			{
				return suspendPeriods;
			}
			set	
			{
				suspendPeriods = value;
				DictionaryUtil.Add(BodyParameters, "suspendPeriods", value);
			}
		}

		public float? MaxCU
		{
			get
			{
				return maxCU;
			}
			set	
			{
				maxCU = value;
				DictionaryUtil.Add(BodyParameters, "maxCU", value.ToString());
			}
		}

		public string Configure
		{
			get
			{
				return configure;
			}
			set	
			{
				configure = value;
				DictionaryUtil.Add(BodyParameters, "configure", value);
			}
		}

		public bool? IsOnOff
		{
			get
			{
				return isOnOff;
			}
			set	
			{
				isOnOff = value;
				DictionaryUtil.Add(BodyParameters, "isOnOff", value.ToString());
			}
		}

		public string JobName
		{
			get
			{
				return jobName;
			}
			set	
			{
				jobName = value;
				DictionaryUtil.Add(PathParameters, "jobName", value);
			}
		}

		public List<SuspendPeriodParam> SuspendPeriodParams
		{
			get
			{
				return suspendPeriodParams;
			}

			set
			{
				suspendPeriodParams = value;
				for (int i = 0; i < suspendPeriodParams.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"suspendPeriodParam." + (i + 1) + ".endTime", suspendPeriodParams[i].EndTime);
					DictionaryUtil.Add(BodyParameters,"suspendPeriodParam." + (i + 1) + ".startTime", suspendPeriodParams[i].StartTime);
					DictionaryUtil.Add(BodyParameters,"suspendPeriodParam." + (i + 1) + ".plan", suspendPeriodParams[i].Plan);
					DictionaryUtil.Add(BodyParameters,"suspendPeriodParam." + (i + 1) + ".policy", suspendPeriodParams[i].Policy);
				}
			}
		}

		public class SuspendPeriodParam
		{

			private string endTime;

			private string startTime;

			private string plan;

			private string policy;

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

			public string Plan
			{
				get
				{
					return plan;
				}
				set	
				{
					plan = value;
				}
			}

			public string Policy
			{
				get
				{
					return policy;
				}
				set	
				{
					policy = value;
				}
			}
		}

        public override CommitJobResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CommitJobResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
