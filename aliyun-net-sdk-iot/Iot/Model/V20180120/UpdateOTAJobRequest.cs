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
using Aliyun.Acs.Iot.Transform;
using Aliyun.Acs.Iot.Transform.V20180120;

namespace Aliyun.Acs.Iot.Model.V20180120
{
    public class UpdateOTAJobRequest : RpcAcsRequest<UpdateOTAJobResponse>
    {
        public UpdateOTAJobRequest()
            : base("Iot", "2018-01-20", "UpdateOTAJob", "iot", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Iot.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Iot.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string upgradeType;

		private int? timeoutInMinutes;

		private string jobId;

		private string iotInstanceId;

		private List<string> srcVersionLists = new List<string>(){ };

		private string targetSelection;

		private List<Tags> tagss = new List<Tags>(){ };

		private int? maximumPerMinute;

		public string UpgradeType
		{
			get
			{
				return upgradeType;
			}
			set	
			{
				upgradeType = value;
				DictionaryUtil.Add(QueryParameters, "UpgradeType", value);
			}
		}

		public int? TimeoutInMinutes
		{
			get
			{
				return timeoutInMinutes;
			}
			set	
			{
				timeoutInMinutes = value;
				DictionaryUtil.Add(QueryParameters, "TimeoutInMinutes", value.ToString());
			}
		}

		public string JobId
		{
			get
			{
				return jobId;
			}
			set	
			{
				jobId = value;
				DictionaryUtil.Add(QueryParameters, "JobId", value);
			}
		}

		public string IotInstanceId
		{
			get
			{
				return iotInstanceId;
			}
			set	
			{
				iotInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "IotInstanceId", value);
			}
		}

		public List<string> SrcVersionLists
		{
			get
			{
				return srcVersionLists;
			}

			set
			{
				srcVersionLists = value;
				for (int i = 0; i < srcVersionLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"SrcVersionList." + (i + 1) , srcVersionLists[i]);
				}
			}
		}

		public string TargetSelection
		{
			get
			{
				return targetSelection;
			}
			set	
			{
				targetSelection = value;
				DictionaryUtil.Add(QueryParameters, "TargetSelection", value);
			}
		}

		public List<Tags> Tagss
		{
			get
			{
				return tagss;
			}

			set
			{
				tagss = value;
				for (int i = 0; i < tagss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Tags." + (i + 1) + ".Value", tagss[i].Value);
					DictionaryUtil.Add(QueryParameters,"Tags." + (i + 1) + ".Key", tagss[i].Key);
				}
			}
		}

		public int? MaximumPerMinute
		{
			get
			{
				return maximumPerMinute;
			}
			set	
			{
				maximumPerMinute = value;
				DictionaryUtil.Add(QueryParameters, "MaximumPerMinute", value.ToString());
			}
		}

		public class Tags
		{

			private string value_;

			private string key;

			public string Value
			{
				get
				{
					return value_;
				}
				set	
				{
					value_ = value;
				}
			}

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}
		}

        public override UpdateOTAJobResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateOTAJobResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
