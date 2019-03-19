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

namespace Aliyun.Acs.Cdn.Model.V20180510
{
	public class ListFCTriggerResponse : AcsResponse
	{

		private string requestId;

		private List<ListFCTrigger_FCTrigger> fCTriggers;

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

		public List<ListFCTrigger_FCTrigger> FCTriggers
		{
			get
			{
				return fCTriggers;
			}
			set	
			{
				fCTriggers = value;
			}
		}

		public class ListFCTrigger_FCTrigger
		{

			private string eventMetaName;

			private string eventMetaVersion;

			private string triggerARN;

			private string roleARN;

			private string sourceArn;

			private string notes;

			public string EventMetaName
			{
				get
				{
					return eventMetaName;
				}
				set	
				{
					eventMetaName = value;
				}
			}

			public string EventMetaVersion
			{
				get
				{
					return eventMetaVersion;
				}
				set	
				{
					eventMetaVersion = value;
				}
			}

			public string TriggerARN
			{
				get
				{
					return triggerARN;
				}
				set	
				{
					triggerARN = value;
				}
			}

			public string RoleARN
			{
				get
				{
					return roleARN;
				}
				set	
				{
					roleARN = value;
				}
			}

			public string SourceArn
			{
				get
				{
					return sourceArn;
				}
				set	
				{
					sourceArn = value;
				}
			}

			public string Notes
			{
				get
				{
					return notes;
				}
				set	
				{
					notes = value;
				}
			}
		}
	}
}
