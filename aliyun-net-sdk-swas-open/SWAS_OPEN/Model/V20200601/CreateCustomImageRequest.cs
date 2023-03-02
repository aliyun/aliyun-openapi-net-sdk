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
using Aliyun.Acs.SWAS_OPEN.Transform;
using Aliyun.Acs.SWAS_OPEN.Transform.V20200601;

namespace Aliyun.Acs.SWAS_OPEN.Model.V20200601
{
    public class CreateCustomImageRequest : RpcAcsRequest<CreateCustomImageResponse>
    {
        public CreateCustomImageRequest()
            : base("SWAS-OPEN", "2020-06-01", "CreateCustomImage", "SWAS-OPEN", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string systemSnapshotId;

		private string dataSnapshotId;

		private string clientToken;

		private string description;

		private string instanceId;

		private string imageName;

		public string SystemSnapshotId
		{
			get
			{
				return systemSnapshotId;
			}
			set	
			{
				systemSnapshotId = value;
				DictionaryUtil.Add(QueryParameters, "SystemSnapshotId", value);
			}
		}

		public string DataSnapshotId
		{
			get
			{
				return dataSnapshotId;
			}
			set	
			{
				dataSnapshotId = value;
				DictionaryUtil.Add(QueryParameters, "DataSnapshotId", value);
			}
		}

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
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

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public string ImageName
		{
			get
			{
				return imageName;
			}
			set	
			{
				imageName = value;
				DictionaryUtil.Add(QueryParameters, "ImageName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateCustomImageResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateCustomImageResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
