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
using Aliyun.Acs.tingwu;
using Aliyun.Acs.tingwu.Transform;
using Aliyun.Acs.tingwu.Transform.V20230930;

namespace Aliyun.Acs.tingwu.Model.V20230930
{
    public class CreateTaskRequest : RoaAcsRequest<CreateTaskResponse>
    {
        public CreateTaskRequest()
            : base("tingwu", "2023-09-30", "CreateTask")
        {
			Protocol = ProtocolType.HTTPS;
			UriPattern = "/openapi/tingwu/v2/tasks";
			Method = MethodType.PUT;
        }

		private string type;

		private string body;

		private string operation;

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(QueryParameters, "type", value);
			}
		}

		public string Body
		{
			get
			{
				return body;
			}
			set	
			{
				body = value;
				DictionaryUtil.Add(BodyParameters, "body", value);
			}
		}

		public string Operation
		{
			get
			{
				return operation;
			}
			set	
			{
				operation = value;
				DictionaryUtil.Add(QueryParameters, "operation", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateTaskResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateTaskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
