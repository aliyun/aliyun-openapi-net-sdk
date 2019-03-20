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
using Aliyun.Acs.Cms.Transform;
using Aliyun.Acs.Cms.Transform.V20180308;

namespace Aliyun.Acs.Cms.Model.V20180308
{
    public class TaskConfigModifyRequest : RpcAcsRequest<TaskConfigModifyResponse>
    {
        public TaskConfigModifyRequest()
            : base("Cms", "2018-03-08", "TaskConfigModify", "cms", "openAPI")
        {
        }

		private List<string> instanceLists;

		private string jsonData;

		private string taskType;

		private string taskScope;

		private string alertConfig;

		private long? groupId;

		private string taskName;

		private long? id;

		private string groupName;

		public List<string> InstanceLists
		{
			get
			{
				return instanceLists;
			}

			set
			{
				instanceLists = value;
				for (int i = 0; i < instanceLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"InstanceList." + (i + 1) , instanceLists[i]);
				}
			}
		}

		public string JsonData
		{
			get
			{
				return jsonData;
			}
			set	
			{
				jsonData = value;
				DictionaryUtil.Add(QueryParameters, "JsonData", value);
			}
		}

		public string TaskType
		{
			get
			{
				return taskType;
			}
			set	
			{
				taskType = value;
				DictionaryUtil.Add(QueryParameters, "TaskType", value);
			}
		}

		public string TaskScope
		{
			get
			{
				return taskScope;
			}
			set	
			{
				taskScope = value;
				DictionaryUtil.Add(QueryParameters, "TaskScope", value);
			}
		}

		public string AlertConfig
		{
			get
			{
				return alertConfig;
			}
			set	
			{
				alertConfig = value;
				DictionaryUtil.Add(QueryParameters, "AlertConfig", value);
			}
		}

		public long? GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
				DictionaryUtil.Add(QueryParameters, "GroupId", value.ToString());
			}
		}

		public string TaskName
		{
			get
			{
				return taskName;
			}
			set	
			{
				taskName = value;
				DictionaryUtil.Add(QueryParameters, "TaskName", value);
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
				DictionaryUtil.Add(QueryParameters, "Id", value.ToString());
			}
		}

		public string GroupName
		{
			get
			{
				return groupName;
			}
			set	
			{
				groupName = value;
				DictionaryUtil.Add(QueryParameters, "GroupName", value);
			}
		}

        public override TaskConfigModifyResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return TaskConfigModifyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
