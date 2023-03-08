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
using Aliyun.Acs.adb.Transform;
using Aliyun.Acs.adb.Transform.V20211201;

namespace Aliyun.Acs.adb.Model.V20211201
{
    public class DescribeDiagnosisSQLInfoRequest : RpcAcsRequest<DescribeDiagnosisSQLInfoResponse>
    {
        public DescribeDiagnosisSQLInfoRequest()
            : base("adb", "2021-12-01", "DescribeDiagnosisSQLInfo", "ads", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.adb.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.adb.Endpoint.endpointRegionalType, null);
            }
        }

		private string dBClusterId;

		private string processState;

		private long? processStartTime;

		private string processId;

		private string processRcHost;

		private string lang;

		public string DBClusterId
		{
			get
			{
				return dBClusterId;
			}
			set	
			{
				dBClusterId = value;
				DictionaryUtil.Add(QueryParameters, "DBClusterId", value);
			}
		}

		public string ProcessState
		{
			get
			{
				return processState;
			}
			set	
			{
				processState = value;
				DictionaryUtil.Add(QueryParameters, "ProcessState", value);
			}
		}

		public long? ProcessStartTime
		{
			get
			{
				return processStartTime;
			}
			set	
			{
				processStartTime = value;
				DictionaryUtil.Add(QueryParameters, "ProcessStartTime", value.ToString());
			}
		}

		public string ProcessId
		{
			get
			{
				return processId;
			}
			set	
			{
				processId = value;
				DictionaryUtil.Add(QueryParameters, "ProcessId", value);
			}
		}

		public string ProcessRcHost
		{
			get
			{
				return processRcHost;
			}
			set	
			{
				processRcHost = value;
				DictionaryUtil.Add(QueryParameters, "ProcessRcHost", value);
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeDiagnosisSQLInfoResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeDiagnosisSQLInfoResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
