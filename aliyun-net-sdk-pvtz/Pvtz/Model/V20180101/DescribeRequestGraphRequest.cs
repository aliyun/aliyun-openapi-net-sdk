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
using Aliyun.Acs.pvtz.Transform;
using Aliyun.Acs.pvtz.Transform.V20180101;

namespace Aliyun.Acs.pvtz.Model.V20180101
{
    public class DescribeRequestGraphRequest : RpcAcsRequest<DescribeRequestGraphResponse>
    {
        public DescribeRequestGraphRequest()
            : base("pvtz", "2018-01-01", "DescribeRequestGraph", "pvtz", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private long? startTimestamp;

		private long? endTimestamp;

		private string vpcId;

		private string userClientIp;

		private string zoneId;

		private string lang;

		public long? StartTimestamp
		{
			get
			{
				return startTimestamp;
			}
			set	
			{
				startTimestamp = value;
				DictionaryUtil.Add(QueryParameters, "StartTimestamp", value.ToString());
			}
		}

		public long? EndTimestamp
		{
			get
			{
				return endTimestamp;
			}
			set	
			{
				endTimestamp = value;
				DictionaryUtil.Add(QueryParameters, "EndTimestamp", value.ToString());
			}
		}

		public string VpcId
		{
			get
			{
				return vpcId;
			}
			set	
			{
				vpcId = value;
				DictionaryUtil.Add(QueryParameters, "VpcId", value);
			}
		}

		public string UserClientIp
		{
			get
			{
				return userClientIp;
			}
			set	
			{
				userClientIp = value;
				DictionaryUtil.Add(QueryParameters, "UserClientIp", value);
			}
		}

		public string ZoneId
		{
			get
			{
				return zoneId;
			}
			set	
			{
				zoneId = value;
				DictionaryUtil.Add(QueryParameters, "ZoneId", value);
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

        public override DescribeRequestGraphResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeRequestGraphResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
