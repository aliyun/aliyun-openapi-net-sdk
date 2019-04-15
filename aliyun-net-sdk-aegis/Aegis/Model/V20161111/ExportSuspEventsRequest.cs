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
using Aliyun.Acs.aegis.Transform;
using Aliyun.Acs.aegis.Transform.V20161111;

namespace Aliyun.Acs.aegis.Model.V20161111
{
    public class ExportSuspEventsRequest : RpcAcsRequest<ExportSuspEventsResponse>
    {
        public ExportSuspEventsRequest()
            : base("aegis", "2016-11-11", "ExportSuspEvents", "vipaegis", "openAPI")
        {
        }

		private string timeEnd;

		private string sourceIp;

		private string name;

		private string dealed;

		private string remark;

		private string from;

		private string timeStart;

		private string lang;

		private string levels;

		private string parentEventTypes;

		private string status;

		public string TimeEnd
		{
			get
			{
				return timeEnd;
			}
			set	
			{
				timeEnd = value;
				DictionaryUtil.Add(QueryParameters, "TimeEnd", value);
			}
		}

		public string SourceIp
		{
			get
			{
				return sourceIp;
			}
			set	
			{
				sourceIp = value;
				DictionaryUtil.Add(QueryParameters, "SourceIp", value);
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

		public string Dealed
		{
			get
			{
				return dealed;
			}
			set	
			{
				dealed = value;
				DictionaryUtil.Add(QueryParameters, "Dealed", value);
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

		public string From
		{
			get
			{
				return from;
			}
			set	
			{
				from = value;
				DictionaryUtil.Add(QueryParameters, "From", value);
			}
		}

		public string TimeStart
		{
			get
			{
				return timeStart;
			}
			set	
			{
				timeStart = value;
				DictionaryUtil.Add(QueryParameters, "TimeStart", value);
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public string Levels
		{
			get
			{
				return levels;
			}
			set	
			{
				levels = value;
				DictionaryUtil.Add(QueryParameters, "Levels", value);
			}
		}

		public string ParentEventTypes
		{
			get
			{
				return parentEventTypes;
			}
			set	
			{
				parentEventTypes = value;
				DictionaryUtil.Add(QueryParameters, "ParentEventTypes", value);
			}
		}

		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
				DictionaryUtil.Add(QueryParameters, "Status", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ExportSuspEventsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ExportSuspEventsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
