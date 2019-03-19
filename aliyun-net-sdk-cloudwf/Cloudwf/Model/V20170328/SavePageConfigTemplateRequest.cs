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
    public class SavePageConfigTemplateRequest : RpcAcsRequest<SavePageConfigTemplateResponse>
    {
        public SavePageConfigTemplateRequest()
            : base("cloudwf", "2017-03-28", "SavePageConfigTemplate", "cloudwf", "openAPI")
        {
        }

		private int? tempType;

		private string tempDesc;

		private string tempName;

		private long? id;

		private string tempPermission;

		private string accessKeyId;

		public int? TempType
		{
			get
			{
				return tempType;
			}
			set	
			{
				tempType = value;
				DictionaryUtil.Add(QueryParameters, "TempType", value.ToString());
			}
		}

		public string TempDesc
		{
			get
			{
				return tempDesc;
			}
			set	
			{
				tempDesc = value;
				DictionaryUtil.Add(QueryParameters, "TempDesc", value);
			}
		}

		public string TempName
		{
			get
			{
				return tempName;
			}
			set	
			{
				tempName = value;
				DictionaryUtil.Add(QueryParameters, "TempName", value);
			}
		}

		public long? Id
		{
			get
			{
				return id;
			}
			set	
			{
				id = value;
				DictionaryUtil.Add(QueryParameters, "Id", value.ToString());
			}
		}

		public string TempPermission
		{
			get
			{
				return tempPermission;
			}
			set	
			{
				tempPermission = value;
				DictionaryUtil.Add(QueryParameters, "TempPermission", value);
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

        public override SavePageConfigTemplateResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SavePageConfigTemplateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
