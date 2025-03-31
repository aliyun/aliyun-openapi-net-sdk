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
    public class SubmitImportLogTasksRequest : RpcAcsRequest<SubmitImportLogTasksResponse>
    {
        public SubmitImportLogTasksRequest()
            : base("cloud-siem", "2022-06-16", "SubmitImportLogTasks", "cloud-siem", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string cloudCode;

		private long? roleFor;

		private int? roleType;

		private string logCodes;

		private string prodCode;

		private int? autoImported;

		private string accounts;

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

		public string LogCodes
		{
			get
			{
				return logCodes;
			}
			set	
			{
				logCodes = value;
				DictionaryUtil.Add(BodyParameters, "LogCodes", value);
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

		public int? AutoImported
		{
			get
			{
				return autoImported;
			}
			set	
			{
				autoImported = value;
				DictionaryUtil.Add(BodyParameters, "AutoImported", value.ToString());
			}
		}

		public string Accounts
		{
			get
			{
				return accounts;
			}
			set	
			{
				accounts = value;
				DictionaryUtil.Add(BodyParameters, "Accounts", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SubmitImportLogTasksResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SubmitImportLogTasksResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
