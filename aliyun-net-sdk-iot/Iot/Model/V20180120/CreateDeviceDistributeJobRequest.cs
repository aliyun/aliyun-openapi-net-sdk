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
    public class CreateDeviceDistributeJobRequest : RpcAcsRequest<CreateDeviceDistributeJobResponse>
    {
        public CreateDeviceDistributeJobRequest()
            : base("Iot", "2018-01-20", "CreateDeviceDistributeJob", "iot", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Iot.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Iot.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string sourceInstanceId;

		private string targetAliyunId;

		private List<TargetInstanceConfig> targetInstanceConfigs = new List<TargetInstanceConfig>(){ };

		private string productKey;

		private List<string> deviceNames = new List<string>(){ };

		private string targetUid;

		private int? strategy;

		public string SourceInstanceId
		{
			get
			{
				return sourceInstanceId;
			}
			set	
			{
				sourceInstanceId = value;
				DictionaryUtil.Add(BodyParameters, "SourceInstanceId", value);
			}
		}

		public string TargetAliyunId
		{
			get
			{
				return targetAliyunId;
			}
			set	
			{
				targetAliyunId = value;
				DictionaryUtil.Add(BodyParameters, "TargetAliyunId", value);
			}
		}

		public List<TargetInstanceConfig> TargetInstanceConfigs
		{
			get
			{
				return targetInstanceConfigs;
			}

			set
			{
				targetInstanceConfigs = value;
				for (int i = 0; i < targetInstanceConfigs.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"TargetInstanceConfig." + (i + 1) + ".TargetInstanceId", targetInstanceConfigs[i].TargetInstanceId);
				}
			}
		}

		public string ProductKey
		{
			get
			{
				return productKey;
			}
			set	
			{
				productKey = value;
				DictionaryUtil.Add(BodyParameters, "ProductKey", value);
			}
		}

		public List<string> DeviceNames
		{
			get
			{
				return deviceNames;
			}

			set
			{
				deviceNames = value;
				for (int i = 0; i < deviceNames.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"DeviceName." + (i + 1) , deviceNames[i]);
				}
			}
		}

		public string TargetUid
		{
			get
			{
				return targetUid;
			}
			set	
			{
				targetUid = value;
				DictionaryUtil.Add(BodyParameters, "TargetUid", value);
			}
		}

		public int? Strategy
		{
			get
			{
				return strategy;
			}
			set	
			{
				strategy = value;
				DictionaryUtil.Add(BodyParameters, "Strategy", value.ToString());
			}
		}

		public class TargetInstanceConfig
		{

			private string targetInstanceId;

			public string TargetInstanceId
			{
				get
				{
					return targetInstanceId;
				}
				set	
				{
					targetInstanceId = value;
				}
			}
		}

        public override CreateDeviceDistributeJobResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateDeviceDistributeJobResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
