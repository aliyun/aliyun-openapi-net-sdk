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
using Aliyun.Acs.schedulerx2;
using Aliyun.Acs.schedulerx2.Transform;
using Aliyun.Acs.schedulerx2.Transform.V20190430;

namespace Aliyun.Acs.schedulerx2.Model.V20190430
{
    public class CreateAppGroupRequest : RpcAcsRequest<CreateAppGroupResponse>
    {
        public CreateAppGroupRequest()
            : base("schedulerx2", "2019-04-30", "CreateAppGroup")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.schedulerx2.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.schedulerx2.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
        }

		private int? maxJobs;

		private string namespaceName;

		private string namespaceSource;

		private string groupId;

		private string description;

		private string appName;

		private string _namespace;

		private string alarmJson;

		public int? MaxJobs
		{
			get
			{
				return maxJobs;
			}
			set	
			{
				maxJobs = value;
				DictionaryUtil.Add(QueryParameters, "MaxJobs", value.ToString());
			}
		}

		public string NamespaceName
		{
			get
			{
				return namespaceName;
			}
			set	
			{
				namespaceName = value;
				DictionaryUtil.Add(QueryParameters, "NamespaceName", value);
			}
		}

		public string NamespaceSource
		{
			get
			{
				return namespaceSource;
			}
			set	
			{
				namespaceSource = value;
				DictionaryUtil.Add(QueryParameters, "NamespaceSource", value);
			}
		}

		public string GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
				DictionaryUtil.Add(QueryParameters, "GroupId", value);
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public string AppName
		{
			get
			{
				return appName;
			}
			set	
			{
				appName = value;
				DictionaryUtil.Add(QueryParameters, "AppName", value);
			}
		}

		public string _Namespace
		{
			get
			{
				return _namespace;
			}
			set	
			{
				_namespace = value;
				DictionaryUtil.Add(QueryParameters, "Namespace", value);
			}
		}

		public string AlarmJson
		{
			get
			{
				return alarmJson;
			}
			set	
			{
				alarmJson = value;
				DictionaryUtil.Add(QueryParameters, "AlarmJson", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateAppGroupResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateAppGroupResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
