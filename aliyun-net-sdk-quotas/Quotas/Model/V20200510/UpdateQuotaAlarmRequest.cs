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
using Aliyun.Acs.quotas.Transform;
using Aliyun.Acs.quotas.Transform.V20200510;

namespace Aliyun.Acs.quotas.Model.V20200510
{
    public class UpdateQuotaAlarmRequest : RpcAcsRequest<UpdateQuotaAlarmResponse>
    {
        public UpdateQuotaAlarmRequest()
            : base("quotas", "2020-05-10", "UpdateQuotaAlarm", "quotas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.quotas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.quotas.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string webHook;

		private float? threshold;

		private string thresholdType;

		private float? thresholdPercent;

		private string alarmId;

		private string alarmName;

		public string WebHook
		{
			get
			{
				return webHook;
			}
			set	
			{
				webHook = value;
				DictionaryUtil.Add(BodyParameters, "WebHook", value);
			}
		}

		public float? Threshold
		{
			get
			{
				return threshold;
			}
			set	
			{
				threshold = value;
				DictionaryUtil.Add(BodyParameters, "Threshold", value.ToString());
			}
		}

		public string ThresholdType
		{
			get
			{
				return thresholdType;
			}
			set	
			{
				thresholdType = value;
				DictionaryUtil.Add(BodyParameters, "ThresholdType", value);
			}
		}

		public float? ThresholdPercent
		{
			get
			{
				return thresholdPercent;
			}
			set	
			{
				thresholdPercent = value;
				DictionaryUtil.Add(BodyParameters, "ThresholdPercent", value.ToString());
			}
		}

		public string AlarmId
		{
			get
			{
				return alarmId;
			}
			set	
			{
				alarmId = value;
				DictionaryUtil.Add(BodyParameters, "AlarmId", value);
			}
		}

		public string AlarmName
		{
			get
			{
				return alarmName;
			}
			set	
			{
				alarmName = value;
				DictionaryUtil.Add(BodyParameters, "AlarmName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateQuotaAlarmResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateQuotaAlarmResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
