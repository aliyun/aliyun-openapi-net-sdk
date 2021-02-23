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
    public class CreateJobRequest : RpcAcsRequest<CreateJobResponse>
    {
        public CreateJobRequest()
            : base("schedulerx2", "2019-04-30", "CreateJob")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.schedulerx2.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.schedulerx2.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string namespaceSource;

		private string description;

		private int? attemptInterval;

		private string content;

		private long? timeout;

		private bool? timeoutKillEnable;

		private int? pageSize;

		private int? consumerSize;

		private string jarUrl;

		private string calendar;

		private bool? failEnable;

		private string sendChannel;

		private int? dataOffset;

		private string groupId;

		private int? taskMaxAttempt;

		private int? maxAttempt;

		private int? dispatcherSize;

		private string jobType;

		private int? taskAttemptInterval;

		private string executeMode;

		private int? queueSize;

		private string timeExpression;

		private string className;

		private bool? timeoutEnable;

		private List<ContactInfo> contactInfos = new List<ContactInfo>(){ };

		private string name;

		private string _namespace;

		private int? maxConcurrency;

		private int? timeType;

		private string parameters;

		public string NamespaceSource
		{
			get
			{
				return namespaceSource;
			}
			set	
			{
				namespaceSource = value;
				DictionaryUtil.Add(BodyParameters, "NamespaceSource", value);
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
				DictionaryUtil.Add(BodyParameters, "Description", value);
			}
		}

		public int? AttemptInterval
		{
			get
			{
				return attemptInterval;
			}
			set	
			{
				attemptInterval = value;
				DictionaryUtil.Add(BodyParameters, "AttemptInterval", value.ToString());
			}
		}

		public string Content
		{
			get
			{
				return content;
			}
			set	
			{
				content = value;
				DictionaryUtil.Add(BodyParameters, "Content", value);
			}
		}

		public long? Timeout
		{
			get
			{
				return timeout;
			}
			set	
			{
				timeout = value;
				DictionaryUtil.Add(BodyParameters, "Timeout", value.ToString());
			}
		}

		public bool? TimeoutKillEnable
		{
			get
			{
				return timeoutKillEnable;
			}
			set	
			{
				timeoutKillEnable = value;
				DictionaryUtil.Add(BodyParameters, "TimeoutKillEnable", value.ToString());
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

		public int? ConsumerSize
		{
			get
			{
				return consumerSize;
			}
			set	
			{
				consumerSize = value;
				DictionaryUtil.Add(BodyParameters, "ConsumerSize", value.ToString());
			}
		}

		public string JarUrl
		{
			get
			{
				return jarUrl;
			}
			set	
			{
				jarUrl = value;
				DictionaryUtil.Add(BodyParameters, "JarUrl", value);
			}
		}

		public string Calendar
		{
			get
			{
				return calendar;
			}
			set	
			{
				calendar = value;
				DictionaryUtil.Add(BodyParameters, "Calendar", value);
			}
		}

		public bool? FailEnable
		{
			get
			{
				return failEnable;
			}
			set	
			{
				failEnable = value;
				DictionaryUtil.Add(BodyParameters, "FailEnable", value.ToString());
			}
		}

		public string SendChannel
		{
			get
			{
				return sendChannel;
			}
			set	
			{
				sendChannel = value;
				DictionaryUtil.Add(BodyParameters, "SendChannel", value);
			}
		}

		public int? DataOffset
		{
			get
			{
				return dataOffset;
			}
			set	
			{
				dataOffset = value;
				DictionaryUtil.Add(BodyParameters, "DataOffset", value.ToString());
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
				DictionaryUtil.Add(BodyParameters, "GroupId", value);
			}
		}

		public int? TaskMaxAttempt
		{
			get
			{
				return taskMaxAttempt;
			}
			set	
			{
				taskMaxAttempt = value;
				DictionaryUtil.Add(BodyParameters, "TaskMaxAttempt", value.ToString());
			}
		}

		public int? MaxAttempt
		{
			get
			{
				return maxAttempt;
			}
			set	
			{
				maxAttempt = value;
				DictionaryUtil.Add(BodyParameters, "MaxAttempt", value.ToString());
			}
		}

		public int? DispatcherSize
		{
			get
			{
				return dispatcherSize;
			}
			set	
			{
				dispatcherSize = value;
				DictionaryUtil.Add(BodyParameters, "DispatcherSize", value.ToString());
			}
		}

		public string JobType
		{
			get
			{
				return jobType;
			}
			set	
			{
				jobType = value;
				DictionaryUtil.Add(BodyParameters, "JobType", value);
			}
		}

		public int? TaskAttemptInterval
		{
			get
			{
				return taskAttemptInterval;
			}
			set	
			{
				taskAttemptInterval = value;
				DictionaryUtil.Add(BodyParameters, "TaskAttemptInterval", value.ToString());
			}
		}

		public string ExecuteMode
		{
			get
			{
				return executeMode;
			}
			set	
			{
				executeMode = value;
				DictionaryUtil.Add(BodyParameters, "ExecuteMode", value);
			}
		}

		public int? QueueSize
		{
			get
			{
				return queueSize;
			}
			set	
			{
				queueSize = value;
				DictionaryUtil.Add(BodyParameters, "QueueSize", value.ToString());
			}
		}

		public string TimeExpression
		{
			get
			{
				return timeExpression;
			}
			set	
			{
				timeExpression = value;
				DictionaryUtil.Add(BodyParameters, "TimeExpression", value);
			}
		}

		public string ClassName
		{
			get
			{
				return className;
			}
			set	
			{
				className = value;
				DictionaryUtil.Add(BodyParameters, "ClassName", value);
			}
		}

		public bool? TimeoutEnable
		{
			get
			{
				return timeoutEnable;
			}
			set	
			{
				timeoutEnable = value;
				DictionaryUtil.Add(BodyParameters, "TimeoutEnable", value.ToString());
			}
		}

		public List<ContactInfo> ContactInfos
		{
			get
			{
				return contactInfos;
			}

			set
			{
				contactInfos = value;
				for (int i = 0; i < contactInfos.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"ContactInfo." + (i + 1) + ".UserPhone", contactInfos[i].UserPhone);
					DictionaryUtil.Add(BodyParameters,"ContactInfo." + (i + 1) + ".UserName", contactInfos[i].UserName);
				}
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
				DictionaryUtil.Add(BodyParameters, "Name", value);
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
				DictionaryUtil.Add(BodyParameters, "Namespace", value);
			}
		}

		public int? MaxConcurrency
		{
			get
			{
				return maxConcurrency;
			}
			set	
			{
				maxConcurrency = value;
				DictionaryUtil.Add(BodyParameters, "MaxConcurrency", value.ToString());
			}
		}

		public int? TimeType
		{
			get
			{
				return timeType;
			}
			set	
			{
				timeType = value;
				DictionaryUtil.Add(BodyParameters, "TimeType", value.ToString());
			}
		}

		public string Parameters
		{
			get
			{
				return parameters;
			}
			set	
			{
				parameters = value;
				DictionaryUtil.Add(BodyParameters, "Parameters", value);
			}
		}

		public class ContactInfo
		{

			private string userPhone;

			private string userName;

			public string UserPhone
			{
				get
				{
					return userPhone;
				}
				set	
				{
					userPhone = value;
				}
			}

			public string UserName
			{
				get
				{
					return userName;
				}
				set	
				{
					userName = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateJobResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateJobResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
