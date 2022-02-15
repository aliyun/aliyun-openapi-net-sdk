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
    public class AddCopyrightFilesRequest : RpcAcsRequest<AddCopyrightFilesResponse>
    {
        public AddCopyrightFilesRequest()
            : base("Copyright", "2019-01-23", "AddCopyrightFiles")
        {
			Method = MethodType.POST;
        }

		private string extInfo;

		private string copyrightOwnersList;

		private string bizType;

		private string contactInfo;

		private string files;

		private string swtype;

		public string ExtInfo
		{
			get
			{
				return extInfo;
			}
			set	
			{
				extInfo = value;
				DictionaryUtil.Add(BodyParameters, "ExtInfo", value);
			}
		}

		public string CopyrightOwnersList
		{
			get
			{
				return copyrightOwnersList;
			}
			set	
			{
				copyrightOwnersList = value;
				DictionaryUtil.Add(BodyParameters, "CopyrightOwnersList", value);
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
				DictionaryUtil.Add(BodyParameters, "BizType", value);
			}
		}

		public string ContactInfo
		{
			get
			{
				return contactInfo;
			}
			set	
			{
				contactInfo = value;
				DictionaryUtil.Add(BodyParameters, "ContactInfo", value);
			}
		}

		public string Files
		{
			get
			{
				return files;
			}
			set	
			{
				files = value;
				DictionaryUtil.Add(BodyParameters, "Files", value);
			}
		}

		public string Swtype
		{
			get
			{
				return swtype;
			}
			set	
			{
				swtype = value;
				DictionaryUtil.Add(BodyParameters, "Swtype", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override AddCopyrightFilesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddCopyrightFilesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
