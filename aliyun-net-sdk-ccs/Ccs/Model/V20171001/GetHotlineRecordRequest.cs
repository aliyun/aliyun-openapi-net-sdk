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
using Aliyun.Acs.Ccs.Transform;
using Aliyun.Acs.Ccs.Transform.V20171001;
using System.Collections.Generic;

namespace Aliyun.Acs.Ccs.Model.V20171001
{
    public class GetHotlineRecordRequest : RpcAcsRequest<GetHotlineRecordResponse>
    {
        public GetHotlineRecordRequest()
            : base("Ccs", "2017-10-01", "GetHotlineRecord", "ccs", "openAPI")
        {
        }

		private string id;

		private string ccsInstanceId;

		public string Id
		{
			get
			{
				return id;
			}
			set	
			{
				id = value;
				DictionaryUtil.Add(QueryParameters, "Id", value);
			}
		}

		public string CcsInstanceId
		{
			get
			{
				return ccsInstanceId;
			}
			set	
			{
				ccsInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "CcsInstanceId", value);
			}
		}

        public override GetHotlineRecordResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return GetHotlineRecordResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}