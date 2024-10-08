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
using Aliyun.Acs.ResourceCenter;
using Aliyun.Acs.ResourceCenter.Transform;
using Aliyun.Acs.ResourceCenter.Transform.V20221201;

namespace Aliyun.Acs.ResourceCenter.Model.V20221201
{
    public class UpdateSavedQueryRequest : RpcAcsRequest<UpdateSavedQueryResponse>
    {
        public UpdateSavedQueryRequest()
            : base("ResourceCenter", "2022-12-01", "UpdateSavedQuery")
        {
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string expression;

		private string description;

		private string queryId;

		private string name;

		public string Expression
		{
			get
			{
				return expression;
			}
			set	
			{
				expression = value;
				DictionaryUtil.Add(QueryParameters, "Expression", value);
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

		public string QueryId
		{
			get
			{
				return queryId;
			}
			set	
			{
				queryId = value;
				DictionaryUtil.Add(QueryParameters, "QueryId", value);
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateSavedQueryResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateSavedQueryResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
