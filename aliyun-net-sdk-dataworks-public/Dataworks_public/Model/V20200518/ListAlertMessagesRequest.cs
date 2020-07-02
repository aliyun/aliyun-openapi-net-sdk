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
using Aliyun.Acs.dataworks_public.Transform;
using Aliyun.Acs.dataworks_public.Transform.V20200518;

namespace Aliyun.Acs.dataworks_public.Model.V20200518
{
    public class ListAlertMessagesRequest : RpcAcsRequest<ListAlertMessagesResponse>
    {
        public ListAlertMessagesRequest()
            : base("dataworks-public", "2020-05-18", "ListAlertMessages", "dide", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string alertUser;

		private string endTime;

		private string beginTime;

		private string alertMethods;

		private int? pageNumber;

		private long? remindId;

		private int? pageSize;

		private string alertRuleTypes;

		public string AlertUser
		{
			get
			{
				return alertUser;
			}
			set	
			{
				alertUser = value;
				DictionaryUtil.Add(BodyParameters, "AlertUser", value);
			}
		}

		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(BodyParameters, "EndTime", value);
			}
		}

		public string BeginTime
		{
			get
			{
				return beginTime;
			}
			set	
			{
				beginTime = value;
				DictionaryUtil.Add(BodyParameters, "BeginTime", value);
			}
		}

		public string AlertMethods
		{
			get
			{
				return alertMethods;
			}
			set	
			{
				alertMethods = value;
				DictionaryUtil.Add(BodyParameters, "AlertMethods", value);
			}
		}

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

		public long? RemindId
		{
			get
			{
				return remindId;
			}
			set	
			{
				remindId = value;
				DictionaryUtil.Add(BodyParameters, "RemindId", value.ToString());
			}
		}

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

		public string AlertRuleTypes
		{
			get
			{
				return alertRuleTypes;
			}
			set	
			{
				alertRuleTypes = value;
				DictionaryUtil.Add(BodyParameters, "AlertRuleTypes", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListAlertMessagesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListAlertMessagesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
