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
using Aliyun.Acs.Linkvisual.Transform;
using Aliyun.Acs.Linkvisual.Transform.V20180120;

namespace Aliyun.Acs.Linkvisual.Model.V20180120
{
    public class CreateEventRecordPlanRequest : RpcAcsRequest<CreateEventRecordPlanResponse>
    {
        public CreateEventRecordPlanRequest()
            : base("Linkvisual", "2018-01-20", "CreateEventRecordPlan", "Linkvisual", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Linkvisual.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Linkvisual.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string eventTypes;

		private int? preRecordDuration;

		private int? recordDuration;

		private string templateId;

		private string name;

		public string EventTypes
		{
			get
			{
				return eventTypes;
			}
			set	
			{
				eventTypes = value;
				DictionaryUtil.Add(QueryParameters, "EventTypes", value);
			}
		}

		public int? PreRecordDuration
		{
			get
			{
				return preRecordDuration;
			}
			set	
			{
				preRecordDuration = value;
				DictionaryUtil.Add(QueryParameters, "PreRecordDuration", value.ToString());
			}
		}

		public int? RecordDuration
		{
			get
			{
				return recordDuration;
			}
			set	
			{
				recordDuration = value;
				DictionaryUtil.Add(QueryParameters, "RecordDuration", value.ToString());
			}
		}

		public string TemplateId
		{
			get
			{
				return templateId;
			}
			set	
			{
				templateId = value;
				DictionaryUtil.Add(QueryParameters, "TemplateId", value);
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

        public override CreateEventRecordPlanResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateEventRecordPlanResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
