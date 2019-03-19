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
using Aliyun.Acs.cloudwf.Transform;
using Aliyun.Acs.cloudwf.Transform.V20170328;

namespace Aliyun.Acs.cloudwf.Model.V20170328
{
    public class UserDataUpdateRequest : RpcAcsRequest<UserDataUpdateResponse>
    {
        public UserDataUpdateRequest()
            : base("cloudwf", "2017-03-28", "UserDataUpdate", "cloudwf", "openAPI")
        {
        }

		private long? iid;

		private string uploadFile;

		private string name;

		private long? bid;

		private string type;

		private string accessKeyId;

		public long? Iid
		{
			get
			{
				return iid;
			}
			set	
			{
				iid = value;
				DictionaryUtil.Add(QueryParameters, "Iid", value.ToString());
			}
		}

		public string UploadFile
		{
			get
			{
				return uploadFile;
			}
			set	
			{
				uploadFile = value;
				DictionaryUtil.Add(QueryParameters, "UploadFile", value);
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

		public long? Bid
		{
			get
			{
				return bid;
			}
			set	
			{
				bid = value;
				DictionaryUtil.Add(QueryParameters, "Bid", value.ToString());
			}
		}

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(QueryParameters, "Type", value);
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

        public override UserDataUpdateResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UserDataUpdateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
