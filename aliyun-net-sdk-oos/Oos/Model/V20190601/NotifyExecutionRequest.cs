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
using Aliyun.Acs.oos.Transform;
using Aliyun.Acs.oos.Transform.V20190601;

namespace Aliyun.Acs.oos.Model.V20190601
{
    public class NotifyExecutionRequest : RpcAcsRequest<NotifyExecutionResponse>
    {
        public NotifyExecutionRequest()
            : base("oos", "2019-06-01", "NotifyExecution", "oos", "openAPI")
        {
        }

		private string executionId;

		private string executionStatus;

		private string notifyNote;

		private string taskName;

		private string notifyType;

		private string parameters;

		public string ExecutionId
		{
			get
			{
				return executionId;
			}
			set	
			{
				executionId = value;
				DictionaryUtil.Add(QueryParameters, "ExecutionId", value);
			}
		}

		public string ExecutionStatus
		{
			get
			{
				return executionStatus;
			}
			set	
			{
				executionStatus = value;
				DictionaryUtil.Add(QueryParameters, "ExecutionStatus", value);
			}
		}

		public string NotifyNote
		{
			get
			{
				return notifyNote;
			}
			set	
			{
				notifyNote = value;
				DictionaryUtil.Add(QueryParameters, "NotifyNote", value);
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

		public string NotifyType
		{
			get
			{
				return notifyType;
			}
			set	
			{
				notifyType = value;
				DictionaryUtil.Add(QueryParameters, "NotifyType", value);
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
				DictionaryUtil.Add(QueryParameters, "Parameters", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override NotifyExecutionResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return NotifyExecutionResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
