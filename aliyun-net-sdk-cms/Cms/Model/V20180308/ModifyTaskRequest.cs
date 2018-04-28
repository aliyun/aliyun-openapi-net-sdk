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
using Aliyun.Acs.Cms.Transform;
using Aliyun.Acs.Cms.Transform.V20180308;
using System.Collections.Generic;

namespace Aliyun.Acs.Cms.Model.V20180308
{
    public class ModifyTaskRequest : RpcAcsRequest<ModifyTaskResponse>
    {
        public ModifyTaskRequest()
            : base("Cms", "2018-03-08", "ModifyTask", "cms", "openAPI")
        {
        }

		private string reportProject;

		private string taskType;

		private string address;

		private string alertName;

		private string ip;

		private string agentGroup;

		private string taskName;

		private string endTime;

		private string taskState;

		private string clientIds;

		private string alertInfo;

		private string agentType;

		private string ispCity;

		private string options;

		private string interval;

		private string alertRule;

		private string taskId;

		public string ReportProject
		{
			get
			{
				return reportProject;
			}
			set	
			{
				reportProject = value;
				DictionaryUtil.Add(QueryParameters, "ReportProject", value);
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

		public string Address
		{
			get
			{
				return address;
			}
			set	
			{
				address = value;
				DictionaryUtil.Add(QueryParameters, "Address", value);
			}
		}

		public string AlertName
		{
			get
			{
				return alertName;
			}
			set	
			{
				alertName = value;
				DictionaryUtil.Add(QueryParameters, "AlertName", value);
			}
		}

		public string Ip
		{
			get
			{
				return ip;
			}
			set	
			{
				ip = value;
				DictionaryUtil.Add(QueryParameters, "Ip", value);
			}
		}

		public string AgentGroup
		{
			get
			{
				return agentGroup;
			}
			set	
			{
				agentGroup = value;
				DictionaryUtil.Add(QueryParameters, "AgentGroup", value);
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

		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(QueryParameters, "EndTime", value);
			}
		}

		public string TaskState
		{
			get
			{
				return taskState;
			}
			set	
			{
				taskState = value;
				DictionaryUtil.Add(QueryParameters, "TaskState", value);
			}
		}

		public string ClientIds
		{
			get
			{
				return clientIds;
			}
			set	
			{
				clientIds = value;
				DictionaryUtil.Add(QueryParameters, "ClientIds", value);
			}
		}

		public string AlertInfo
		{
			get
			{
				return alertInfo;
			}
			set	
			{
				alertInfo = value;
				DictionaryUtil.Add(QueryParameters, "AlertInfo", value);
			}
		}

		public string AgentType
		{
			get
			{
				return agentType;
			}
			set	
			{
				agentType = value;
				DictionaryUtil.Add(QueryParameters, "AgentType", value);
			}
		}

		public string IspCity
		{
			get
			{
				return ispCity;
			}
			set	
			{
				ispCity = value;
				DictionaryUtil.Add(QueryParameters, "IspCity", value);
			}
		}

		public string Options
		{
			get
			{
				return options;
			}
			set	
			{
				options = value;
				DictionaryUtil.Add(QueryParameters, "Options", value);
			}
		}

		public string Interval
		{
			get
			{
				return interval;
			}
			set	
			{
				interval = value;
				DictionaryUtil.Add(QueryParameters, "Interval", value);
			}
		}

		public string AlertRule
		{
			get
			{
				return alertRule;
			}
			set	
			{
				alertRule = value;
				DictionaryUtil.Add(QueryParameters, "AlertRule", value);
			}
		}

		public string TaskId
		{
			get
			{
				return taskId;
			}
			set	
			{
				taskId = value;
				DictionaryUtil.Add(QueryParameters, "TaskId", value);
			}
		}

        public override ModifyTaskResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ModifyTaskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}