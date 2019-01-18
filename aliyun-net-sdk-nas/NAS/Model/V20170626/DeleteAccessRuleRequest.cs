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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.NAS.Transform;
using Aliyun.Acs.NAS.Transform.V20170626;
using System.Collections.Generic;

namespace Aliyun.Acs.NAS.Model.V20170626
{
    public class DeleteAccessRuleRequest : RpcAcsRequest<DeleteAccessRuleResponse>
    {
        public DeleteAccessRuleRequest()
            : base("NAS", "2017-06-26", "DeleteAccessRule", "nas", "openAPI")
        {
        }

		private string accessGroupName;

		private string accessRuleId;

		public string AccessGroupName
		{
			get
			{
				return accessGroupName;
			}
			set	
			{
				accessGroupName = value;
				DictionaryUtil.Add(QueryParameters, "AccessGroupName", value);
			}
		}

		public string AccessRuleId
		{
			get
			{
				return accessRuleId;
			}
			set	
			{
				accessRuleId = value;
				DictionaryUtil.Add(QueryParameters, "AccessRuleId", value);
			}
		}

        public override DeleteAccessRuleResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DeleteAccessRuleResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}