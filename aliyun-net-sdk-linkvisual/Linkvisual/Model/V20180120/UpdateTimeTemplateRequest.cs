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
    public class UpdateTimeTemplateRequest : RpcAcsRequest<UpdateTimeTemplateResponse>
    {
        public UpdateTimeTemplateRequest()
            : base("Linkvisual", "2018-01-20", "UpdateTimeTemplate", "Linkvisual", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Linkvisual.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Linkvisual.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<int?> timeSectionss = new List<int?>(){ };

		private string templateId;

		private int? allDay;

		private string name;

		public List<int?> TimeSectionss
		{
			get
			{
				return timeSectionss;
			}

			set
			{
				timeSectionss = value;
				if(timeSectionss != null)
				{
					for (int depth1 = 0; depth1 < timeSectionss.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"TimeSections." + (depth1 + 1), timeSectionss[depth1]);
						DictionaryUtil.Add(QueryParameters,"TimeSections." + (depth1 + 1), timeSectionss[depth1]);
						DictionaryUtil.Add(QueryParameters,"TimeSections." + (depth1 + 1), timeSectionss[depth1]);
					}
				}
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

		public int? AllDay
		{
			get
			{
				return allDay;
			}
			set	
			{
				allDay = value;
				DictionaryUtil.Add(QueryParameters, "AllDay", value.ToString());
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

		public class TimeSections
		{

			private int? dayOfWeek;

			private int? begin;

			private int? end;

			public int? DayOfWeek
			{
				get
				{
					return dayOfWeek;
				}
				set	
				{
					dayOfWeek = value;
				}
			}

			public int? Begin
			{
				get
				{
					return begin;
				}
				set	
				{
					begin = value;
				}
			}

			public int? End
			{
				get
				{
					return end;
				}
				set	
				{
					end = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateTimeTemplateResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateTimeTemplateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
