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
using System.Collections.Generic;

namespace Aliyun.Acs.vod.Model.V20170321
{
	public class GetAuditResultResponse : AcsResponse
	{

		private string requestId;

		private GetAuditResult_AIAuditResult aIAuditResult;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public GetAuditResult_AIAuditResult AIAuditResult
		{
			get
			{
				return aIAuditResult;
			}
			set	
			{
				aIAuditResult = value;
			}
		}

		public class GetAuditResult_AIAuditResult
		{

			private string abnormalModules;

			private string label;

			private string pornResult;

			private string terrorismResult;

			private string titleResult;

			private string coverResult;

			public string AbnormalModules
			{
				get
				{
					return abnormalModules;
				}
				set	
				{
					abnormalModules = value;
				}
			}

			public string Label
			{
				get
				{
					return label;
				}
				set	
				{
					label = value;
				}
			}

			public string PornResult
			{
				get
				{
					return pornResult;
				}
				set	
				{
					pornResult = value;
				}
			}

			public string TerrorismResult
			{
				get
				{
					return terrorismResult;
				}
				set	
				{
					terrorismResult = value;
				}
			}

			public string TitleResult
			{
				get
				{
					return titleResult;
				}
				set	
				{
					titleResult = value;
				}
			}

			public string CoverResult
			{
				get
				{
					return coverResult;
				}
				set	
				{
					coverResult = value;
				}
			}
		}
	}
}