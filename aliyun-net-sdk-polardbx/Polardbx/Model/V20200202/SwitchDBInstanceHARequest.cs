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
using Aliyun.Acs.polardbx.Transform;
using Aliyun.Acs.polardbx.Transform.V20200202;

namespace Aliyun.Acs.polardbx.Model.V20200202
{
    public class SwitchDBInstanceHARequest : RpcAcsRequest<SwitchDBInstanceHAResponse>
    {
        public SwitchDBInstanceHARequest()
            : base("polardbx", "2020-02-02", "SwitchDBInstanceHA", "polardbx", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.polardbx.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.polardbx.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string dBInstanceName;

		private string targetPrimaryRegionId;

		private string switchTimeMode;

		private string targetPrimaryAzoneId;

		private string switchTime;

		public string DBInstanceName
		{
			get
			{
				return dBInstanceName;
			}
			set	
			{
				dBInstanceName = value;
				DictionaryUtil.Add(QueryParameters, "DBInstanceName", value);
			}
		}

		public string TargetPrimaryRegionId
		{
			get
			{
				return targetPrimaryRegionId;
			}
			set	
			{
				targetPrimaryRegionId = value;
				DictionaryUtil.Add(QueryParameters, "TargetPrimaryRegionId", value);
			}
		}

		public string SwitchTimeMode
		{
			get
			{
				return switchTimeMode;
			}
			set	
			{
				switchTimeMode = value;
				DictionaryUtil.Add(QueryParameters, "SwitchTimeMode", value);
			}
		}

		public string TargetPrimaryAzoneId
		{
			get
			{
				return targetPrimaryAzoneId;
			}
			set	
			{
				targetPrimaryAzoneId = value;
				DictionaryUtil.Add(QueryParameters, "TargetPrimaryAzoneId", value);
			}
		}

		public string SwitchTime
		{
			get
			{
				return switchTime;
			}
			set	
			{
				switchTime = value;
				DictionaryUtil.Add(QueryParameters, "SwitchTime", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SwitchDBInstanceHAResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SwitchDBInstanceHAResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
