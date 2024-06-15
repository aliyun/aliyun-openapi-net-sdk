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
    public class ModifyActiveOperationMaintainConfRequest : RpcAcsRequest<ModifyActiveOperationMaintainConfResponse>
    {
        public ModifyActiveOperationMaintainConfRequest()
            : base("polardbx", "2020-02-02", "ModifyActiveOperationMaintainConf", "polardbx", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.polardbx.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.polardbx.Endpoint.endpointRegionalType, null);
            }
        }

		private string cycleTime;

		private string maintainStartTime;

		private string cycleType;

		private string maintainEndTime;

		private int? status;

		public string CycleTime
		{
			get
			{
				return cycleTime;
			}
			set	
			{
				cycleTime = value;
				DictionaryUtil.Add(QueryParameters, "CycleTime", value);
			}
		}

		public string MaintainStartTime
		{
			get
			{
				return maintainStartTime;
			}
			set	
			{
				maintainStartTime = value;
				DictionaryUtil.Add(QueryParameters, "MaintainStartTime", value);
			}
		}

		public string CycleType
		{
			get
			{
				return cycleType;
			}
			set	
			{
				cycleType = value;
				DictionaryUtil.Add(QueryParameters, "CycleType", value);
			}
		}

		public string MaintainEndTime
		{
			get
			{
				return maintainEndTime;
			}
			set	
			{
				maintainEndTime = value;
				DictionaryUtil.Add(QueryParameters, "MaintainEndTime", value);
			}
		}

		public int? Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
				DictionaryUtil.Add(QueryParameters, "Status", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ModifyActiveOperationMaintainConfResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyActiveOperationMaintainConfResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
