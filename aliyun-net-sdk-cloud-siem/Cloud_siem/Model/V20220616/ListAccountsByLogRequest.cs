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
using Aliyun.Acs.cloud_siem.Transform;
using Aliyun.Acs.cloud_siem.Transform.V20220616;

namespace Aliyun.Acs.cloud_siem.Model.V20220616
{
    public class ListAccountsByLogRequest : RpcAcsRequest<ListAccountsByLogResponse>
    {
        public ListAccountsByLogRequest()
            : base("cloud-siem", "2022-06-16", "ListAccountsByLog", "cloud-siem", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string cloudCode;

		private long? roleFor;

		private int? roleType;

		private List<string> logCodess = new List<string>(){ };

		private string prodCode;

		public string CloudCode
		{
			get
			{
				return cloudCode;
			}
			set	
			{
				cloudCode = value;
				DictionaryUtil.Add(BodyParameters, "CloudCode", value);
			}
		}

		public long? RoleFor
		{
			get
			{
				return roleFor;
			}
			set	
			{
				roleFor = value;
				DictionaryUtil.Add(BodyParameters, "RoleFor", value.ToString());
			}
		}

		public int? RoleType
		{
			get
			{
				return roleType;
			}
			set	
			{
				roleType = value;
				DictionaryUtil.Add(BodyParameters, "RoleType", value.ToString());
			}
		}

		public List<string> LogCodess
		{
			get
			{
				return logCodess;
			}

			set
			{
				logCodess = value;
			}
		}

		public string ProdCode
		{
			get
			{
				return prodCode;
			}
			set	
			{
				prodCode = value;
				DictionaryUtil.Add(BodyParameters, "ProdCode", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListAccountsByLogResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListAccountsByLogResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
