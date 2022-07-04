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
    public class AddDataLevelPermissionWhiteListRequest : RpcAcsRequest<AddDataLevelPermissionWhiteListResponse>
    {
        public AddDataLevelPermissionWhiteListRequest()
            : base("quickbi-public", "2022-01-01", "AddDataLevelPermissionWhiteList", "quick", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string targetType;

		private string targetIds;

		private string ruleType;

		private string operateType;

		private string cubeId;

		public string TargetType
		{
			get
			{
				return targetType;
			}
			set	
			{
				targetType = value;
				DictionaryUtil.Add(QueryParameters, "TargetType", value);
			}
		}

		public string TargetIds
		{
			get
			{
				return targetIds;
			}
			set	
			{
				targetIds = value;
				DictionaryUtil.Add(QueryParameters, "TargetIds", value);
			}
		}

		public string RuleType
		{
			get
			{
				return ruleType;
			}
			set	
			{
				ruleType = value;
				DictionaryUtil.Add(QueryParameters, "RuleType", value);
			}
		}

		public string OperateType
		{
			get
			{
				return operateType;
			}
			set	
			{
				operateType = value;
				DictionaryUtil.Add(QueryParameters, "OperateType", value);
			}
		}

		public string CubeId
		{
			get
			{
				return cubeId;
			}
			set	
			{
				cubeId = value;
				DictionaryUtil.Add(QueryParameters, "CubeId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override AddDataLevelPermissionWhiteListResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddDataLevelPermissionWhiteListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
