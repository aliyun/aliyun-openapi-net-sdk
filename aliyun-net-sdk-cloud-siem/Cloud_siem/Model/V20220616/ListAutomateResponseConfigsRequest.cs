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
    public class ListAutomateResponseConfigsRequest : RpcAcsRequest<ListAutomateResponseConfigsResponse>
    {
        public ListAutomateResponseConfigsRequest()
            : base("cloud-siem", "2022-06-16", "ListAutomateResponseConfigs", "cloud-siem", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string actionType;

		private string ruleName;

		private long? subUserId;

		private int? pageSize;

		private string autoResponseType;

		private long? id;

		private int? currentPage;

		private string playbookUuid;

		private int? status;

		public string ActionType
		{
			get
			{
				return actionType;
			}
			set	
			{
				actionType = value;
				DictionaryUtil.Add(BodyParameters, "ActionType", value);
			}
		}

		public string RuleName
		{
			get
			{
				return ruleName;
			}
			set	
			{
				ruleName = value;
				DictionaryUtil.Add(BodyParameters, "RuleName", value);
			}
		}

		public long? SubUserId
		{
			get
			{
				return subUserId;
			}
			set	
			{
				subUserId = value;
				DictionaryUtil.Add(BodyParameters, "SubUserId", value.ToString());
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(BodyParameters, "PageSize", value.ToString());
			}
		}

		public string AutoResponseType
		{
			get
			{
				return autoResponseType;
			}
			set	
			{
				autoResponseType = value;
				DictionaryUtil.Add(BodyParameters, "AutoResponseType", value);
			}
		}

		public long? Id
		{
			get
			{
				return id;
			}
			set	
			{
				id = value;
				DictionaryUtil.Add(BodyParameters, "Id", value.ToString());
			}
		}

		public int? CurrentPage
		{
			get
			{
				return currentPage;
			}
			set	
			{
				currentPage = value;
				DictionaryUtil.Add(BodyParameters, "CurrentPage", value.ToString());
			}
		}

		public string PlaybookUuid
		{
			get
			{
				return playbookUuid;
			}
			set	
			{
				playbookUuid = value;
				DictionaryUtil.Add(BodyParameters, "PlaybookUuid", value);
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
				DictionaryUtil.Add(BodyParameters, "Status", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListAutomateResponseConfigsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListAutomateResponseConfigsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
