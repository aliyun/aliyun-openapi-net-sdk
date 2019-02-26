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
using Aliyun.Acs.industry_brain.Transform;
using Aliyun.Acs.industry_brain.Transform.V20180712;
using System.Collections.Generic;

namespace Aliyun.Acs.industry_brain.Model.V20180712
{
    public class GetAsyncServiceResultRequest : RpcAcsRequest<GetAsyncServiceResultResponse>
    {
        public GetAsyncServiceResultRequest()
            : base("industry_brain", "2018-07-12", "GetAsyncServiceResult")
        {
        }

		private string taskId;

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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetAsyncServiceResultResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return GetAsyncServiceResultResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}