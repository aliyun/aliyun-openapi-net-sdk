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
using Aliyun.Acs.CloudPhoto.Transform;
using Aliyun.Acs.CloudPhoto.Transform.V20170711;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudPhoto.Model.V20170711
{
    public class EditPhotoStoreRequest : RpcAcsRequest<EditPhotoStoreResponse>
    {
        public EditPhotoStoreRequest()
            : base("CloudPhoto", "2017-07-11", "EditPhotoStore", "cloudphoto", "openAPI")
        {
			Protocol = ProtocolType.HTTPS;
        }

		private string autoCleanEnabled;

		private string storeName;

		private string remark;

		private long? defaultQuota;

		private int? autoCleanDays;

		public string AutoCleanEnabled
		{
			get
			{
				return autoCleanEnabled;
			}
			set	
			{
				autoCleanEnabled = value;
				DictionaryUtil.Add(QueryParameters, "AutoCleanEnabled", value);
			}
		}

		public string StoreName
		{
			get
			{
				return storeName;
			}
			set	
			{
				storeName = value;
				DictionaryUtil.Add(QueryParameters, "StoreName", value);
			}
		}

		public string Remark
		{
			get
			{
				return remark;
			}
			set	
			{
				remark = value;
				DictionaryUtil.Add(QueryParameters, "Remark", value);
			}
		}

		public long? DefaultQuota
		{
			get
			{
				return defaultQuota;
			}
			set	
			{
				defaultQuota = value;
				DictionaryUtil.Add(QueryParameters, "DefaultQuota", value.ToString());
			}
		}

		public int? AutoCleanDays
		{
			get
			{
				return autoCleanDays;
			}
			set	
			{
				autoCleanDays = value;
				DictionaryUtil.Add(QueryParameters, "AutoCleanDays", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override EditPhotoStoreResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return EditPhotoStoreResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}