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
using Aliyun.Acs.Cms.Transform;
using Aliyun.Acs.Cms.Transform.V20180308;

namespace Aliyun.Acs.Cms.Model.V20180308
{
    public class UpdateMonitoringTemplateRequest : RpcAcsRequest<UpdateMonitoringTemplateResponse>
    {
        public UpdateMonitoringTemplateRequest()
            : base("Cms", "2018-03-08", "UpdateMonitoringTemplate", "cms", "openAPI")
        {
        }

		private string eventRuleTemplatesJson;

		private string name;

		private long? restVersion;

		private string description;

		private long? id;

		private string alertTemplatesJson;

		public string EventRuleTemplatesJson
		{
			get
			{
				return eventRuleTemplatesJson;
			}
			set	
			{
				eventRuleTemplatesJson = value;
				DictionaryUtil.Add(QueryParameters, "EventRuleTemplatesJson", value);
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

		public long? RestVersion
		{
			get
			{
				return restVersion;
			}
			set	
			{
				restVersion = value;
				DictionaryUtil.Add(QueryParameters, "RestVersion", value.ToString());
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

		public string AlertTemplatesJson
		{
			get
			{
				return alertTemplatesJson;
			}
			set	
			{
				alertTemplatesJson = value;
				DictionaryUtil.Add(QueryParameters, "AlertTemplatesJson", value);
			}
		}

        public override UpdateMonitoringTemplateResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateMonitoringTemplateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
