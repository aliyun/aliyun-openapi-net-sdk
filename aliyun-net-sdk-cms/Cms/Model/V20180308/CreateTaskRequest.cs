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
    public class CreateTaskRequest : RpcAcsRequest<CreateTaskResponse>
    {
        public CreateTaskRequest()
            : base("Cms", "2018-03-08", "CreateTask", "cms", "openAPI")
        {
        }

		private string address;

		private string taskType;

		private string ispCity;

		private string alertIds;

		private string options;

		private string taskName;

		private string interval;

		private string alertRule;

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

		public string AlertIds
		{
			get
			{
				return alertIds;
			}
			set	
			{
				alertIds = value;
				DictionaryUtil.Add(QueryParameters, "AlertIds", value);
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

        public override CreateTaskResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CreateTaskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}