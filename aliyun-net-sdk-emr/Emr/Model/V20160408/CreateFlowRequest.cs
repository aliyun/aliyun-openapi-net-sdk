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
        }

		private string cronExpr;

		private string parentFlowList;

		private string alertDingDingGroupBizId;

		private long? startSchedule;

		private string description;

		private string clusterId;

		private string alertUserGroupBizId;

		private string hostName;

		private string application;

		private string regionId;

		private bool? createCluster;

		private string name;

		private long? endSchedule;

		private string alertConf;

		private string projectId;

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

		public string RegionId
		{
			get
			{
				return regionId;
			}
			set	
			{
				regionId = value;
				DictionaryUtil.Add(QueryParameters, "RegionId", value);
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
