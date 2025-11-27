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
using Aliyun.Acs.quickbi_public.Transform;
using Aliyun.Acs.quickbi_public.Transform.V20220101;

namespace Aliyun.Acs.quickbi_public.Model.V20220101
{
    public class ModifyDashboardNl2sqlStatusRequest : RpcAcsRequest<ModifyDashboardNl2sqlStatusResponse>
    {
        public ModifyDashboardNl2sqlStatusRequest()
            : base("quickbi-public", "2022-01-01", "ModifyDashboardNl2sqlStatus", "2.2.0", "openAPI")
        {
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string dashboardIds;

		private int? status;

		public string DashboardIds
		{
			get
			{
				return dashboardIds;
			}
			set	
			{
				dashboardIds = value;
				DictionaryUtil.Add(QueryParameters, "DashboardIds", value);
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

        public override ModifyDashboardNl2sqlStatusResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyDashboardNl2sqlStatusResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
