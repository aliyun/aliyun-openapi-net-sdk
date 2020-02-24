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

namespace Aliyun.Acs.VoiceNavigator.Model.V20180612
{
	public class DescribeKnowledgeResponse : AcsResponse
	{

		private string requestId;

		private string navigationScriptId;

		private string instanceId;

		private string categoryId;

		private string userUtterance;

		private string answer;

		private bool? interruptible;

		private List<string> similarUtterances;

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

		public string NavigationScriptId
		{
			get
			{
				return navigationScriptId;
			}
			set	
			{
				navigationScriptId = value;
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
			}
		}

		public string CategoryId
		{
			get
			{
				return categoryId;
			}
			set	
			{
				categoryId = value;
			}
		}

		public string UserUtterance
		{
			get
			{
				return userUtterance;
			}
			set	
			{
				userUtterance = value;
			}
		}

		public string Answer
		{
			get
			{
				return answer;
			}
			set	
			{
				answer = value;
			}
		}

		public bool? Interruptible
		{
			get
			{
				return interruptible;
			}
			set	
			{
				interruptible = value;
			}
		}

		public List<string> SimilarUtterances
		{
			get
			{
				return similarUtterances;
			}
			set	
			{
				similarUtterances = value;
			}
		}
	}
}
