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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.appstream_center;
using Aliyun.Acs.appstream_center.Transform;
using Aliyun.Acs.appstream_center.Transform.V20210901;

namespace Aliyun.Acs.appstream_center.Model.V20210901
{
    public class ListOtaTaskRequest : RpcAcsRequest<ListOtaTaskResponse>
    {
        public ListOtaTaskRequest()
            : base("appstream-center", "2021-09-01", "ListOtaTask")
        {
			Method = MethodType.POST;
        }

		private string otaType;

		private int? pageNumber;

		private string appInstanceGroupId;

		private int? pageSize;

		[JsonProperty(PropertyName = "OtaType")]
		public string OtaType
		{
			get
			{
				return otaType;
			}
			set	
			{
				otaType = value;
				DictionaryUtil.Add(BodyParameters, "OtaType", value);
			}
		}

		[JsonProperty(PropertyName = "PageNumber")]
		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(BodyParameters, "PageNumber", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "AppInstanceGroupId")]
		public string AppInstanceGroupId
		{
			get
			{
				return appInstanceGroupId;
			}
			set	
			{
				appInstanceGroupId = value;
				DictionaryUtil.Add(BodyParameters, "AppInstanceGroupId", value);
			}
		}

		[JsonProperty(PropertyName = "PageSize")]
		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(BodyParameters, "PageSize", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListOtaTaskResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListOtaTaskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
