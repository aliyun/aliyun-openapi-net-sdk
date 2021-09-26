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
using Aliyun.Acs.vs.Transform;
using Aliyun.Acs.vs.Transform.V20181212;

namespace Aliyun.Acs.vs.Model.V20181212
{
    public class UploadDeviceRecordRequest : RpcAcsRequest<UploadDeviceRecordResponse>
    {
        public UploadDeviceRecordRequest()
            : base("vs", "2018-12-12", "UploadDeviceRecord", "vs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.vs.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.vs.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string searchCriteria;

		private string uploadParams;

		private string streamId;

		private string uploadId;

		private string uploadType;

		private string uploadMode;

		private long? ownerId;

		private string deviceId;

		public string SearchCriteria
		{
			get
			{
				return searchCriteria;
			}
			set	
			{
				searchCriteria = value;
				DictionaryUtil.Add(QueryParameters, "SearchCriteria", value);
			}
		}

		public string UploadParams
		{
			get
			{
				return uploadParams;
			}
			set	
			{
				uploadParams = value;
				DictionaryUtil.Add(QueryParameters, "UploadParams", value);
			}
		}

		public string StreamId
		{
			get
			{
				return streamId;
			}
			set	
			{
				streamId = value;
				DictionaryUtil.Add(QueryParameters, "StreamId", value);
			}
		}

		public string UploadId
		{
			get
			{
				return uploadId;
			}
			set	
			{
				uploadId = value;
				DictionaryUtil.Add(QueryParameters, "UploadId", value);
			}
		}

		public string UploadType
		{
			get
			{
				return uploadType;
			}
			set	
			{
				uploadType = value;
				DictionaryUtil.Add(QueryParameters, "UploadType", value);
			}
		}

		public string UploadMode
		{
			get
			{
				return uploadMode;
			}
			set	
			{
				uploadMode = value;
				DictionaryUtil.Add(QueryParameters, "UploadMode", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string DeviceId
		{
			get
			{
				return deviceId;
			}
			set	
			{
				deviceId = value;
				DictionaryUtil.Add(QueryParameters, "DeviceId", value);
			}
		}

        public override UploadDeviceRecordResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UploadDeviceRecordResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
