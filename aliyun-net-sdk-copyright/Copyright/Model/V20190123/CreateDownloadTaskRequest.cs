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
using Aliyun.Acs.Copyright;
using Aliyun.Acs.Copyright.Transform;
using Aliyun.Acs.Copyright.Transform.V20190123;

namespace Aliyun.Acs.Copyright.Model.V20190123
{
    public class CreateDownloadTaskRequest : RpcAcsRequest<CreateDownloadTaskResponse>
    {
        public CreateDownloadTaskRequest()
            : base("Copyright", "2019-01-23", "CreateDownloadTask")
        {
			Method = MethodType.POST;
        }

		private long? dateEnd;

		private string downloadType;

		private string bizType;

		private long? dateStart;

		private string name;

		public long? DateEnd
		{
			get
			{
				return dateEnd;
			}
			set	
			{
				dateEnd = value;
				DictionaryUtil.Add(QueryParameters, "DateEnd", value.ToString());
			}
		}

		public string DownloadType
		{
			get
			{
				return downloadType;
			}
			set	
			{
				downloadType = value;
				DictionaryUtil.Add(QueryParameters, "DownloadType", value);
			}
		}

		public string BizType
		{
			get
			{
				return bizType;
			}
			set	
			{
				bizType = value;
				DictionaryUtil.Add(QueryParameters, "BizType", value);
			}
		}

		public long? DateStart
		{
			get
			{
				return dateStart;
			}
			set	
			{
				dateStart = value;
				DictionaryUtil.Add(QueryParameters, "DateStart", value.ToString());
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

        public override CreateDownloadTaskResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateDownloadTaskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
