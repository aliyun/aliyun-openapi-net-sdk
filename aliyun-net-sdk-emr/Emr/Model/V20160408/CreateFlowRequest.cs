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
using Aliyun.Acs.Emr.Transform;
using Aliyun.Acs.Emr.Transform.V20160408;

namespace Aliyun.Acs.Emr.Model.V20160408
{
    public class CreateFlowRequest : RpcAcsRequest<CreateFlowResponse>
    {
        public CreateFlowRequest()
            : base("Emr", "2016-04-08", "CreateFlow", "emr", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Emr.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Emr.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string cronExpr;

		private string description;

		private string alertUserGroupBizId;

		private string lifecycle;

		private string hostName;

		private bool? createCluster;

		private long? endSchedule;

		private string alertConf;

		private string projectId;

		private string parentFlowList;

		private string logArchiveLocation;

		private string alertDingDingGroupBizId;

		private long? startSchedule;

		private string clusterId;

		private string application;

		private string name;

		private string _namespace;

		private string parentCategory;

		public string CronExpr
		{
			get
			{
				return cronExpr;
			}
			set	
			{
				cronExpr = value;
				DictionaryUtil.Add(QueryParameters, "CronExpr", value);
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

		public string AlertUserGroupBizId
		{
			get
			{
				return alertUserGroupBizId;
			}
			set	
			{
				alertUserGroupBizId = value;
				DictionaryUtil.Add(QueryParameters, "AlertUserGroupBizId", value);
			}
		}

		public string Lifecycle
		{
			get
			{
				return lifecycle;
			}
			set	
			{
				lifecycle = value;
				DictionaryUtil.Add(QueryParameters, "Lifecycle", value);
			}
		}

		public string HostName
		{
			get
			{
				return hostName;
			}
			set	
			{
				hostName = value;
				DictionaryUtil.Add(QueryParameters, "HostName", value);
			}
		}

		public bool? CreateCluster
		{
			get
			{
				return createCluster;
			}
			set	
			{
				createCluster = value;
				DictionaryUtil.Add(QueryParameters, "CreateCluster", value.ToString());
			}
		}

		public long? EndSchedule
		{
			get
			{
				return endSchedule;
			}
			set	
			{
				endSchedule = value;
				DictionaryUtil.Add(QueryParameters, "EndSchedule", value.ToString());
			}
		}

		public string AlertConf
		{
			get
			{
				return alertConf;
			}
			set	
			{
				alertConf = value;
				DictionaryUtil.Add(QueryParameters, "AlertConf", value);
			}
		}

		public string ProjectId
		{
			get
			{
				return projectId;
			}
			set	
			{
				projectId = value;
				DictionaryUtil.Add(QueryParameters, "ProjectId", value);
			}
		}

		public string ParentFlowList
		{
			get
			{
				return parentFlowList;
			}
			set	
			{
				parentFlowList = value;
				DictionaryUtil.Add(QueryParameters, "ParentFlowList", value);
			}
		}

		public string LogArchiveLocation
		{
			get
			{
				return logArchiveLocation;
			}
			set	
			{
				logArchiveLocation = value;
				DictionaryUtil.Add(QueryParameters, "LogArchiveLocation", value);
			}
		}

		public string AlertDingDingGroupBizId
		{
			get
			{
				return alertDingDingGroupBizId;
			}
			set	
			{
				alertDingDingGroupBizId = value;
				DictionaryUtil.Add(QueryParameters, "AlertDingDingGroupBizId", value);
			}
		}

		public long? StartSchedule
		{
			get
			{
				return startSchedule;
			}
			set	
			{
				startSchedule = value;
				DictionaryUtil.Add(QueryParameters, "StartSchedule", value.ToString());
			}
		}

		public string ClusterId
		{
			get
			{
				return clusterId;
			}
			set	
			{
				clusterId = value;
				DictionaryUtil.Add(QueryParameters, "ClusterId", value);
			}
		}

		public string Application
		{
			get
			{
				return application;
			}
			set	
			{
				application = value;
				DictionaryUtil.Add(QueryParameters, "Application", value);
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
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

		public string ParentCategory
		{
			get
			{
				return parentCategory;
			}
			set	
			{
				parentCategory = value;
				DictionaryUtil.Add(QueryParameters, "ParentCategory", value);
			}
		}

        public override CreateFlowResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateFlowResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
