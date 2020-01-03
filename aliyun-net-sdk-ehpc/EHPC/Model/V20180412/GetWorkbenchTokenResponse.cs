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

namespace Aliyun.Acs.EHPC.Model.V20180412
{
	public class GetWorkbenchTokenResponse : AcsResponse
	{

		private string requestId;

		private GetWorkbenchToken_Root root;

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

		public GetWorkbenchToken_Root Root
		{
			get
			{
				return root;
			}
			set	
			{
				root = value;
			}
		}

		public class GetWorkbenchToken_Root
		{

			private GetWorkbenchToken_InstanceLoginView instanceLoginView;

			public GetWorkbenchToken_InstanceLoginView InstanceLoginView
			{
				get
				{
					return instanceLoginView;
				}
				set	
				{
					instanceLoginView = value;
				}
			}

			public class GetWorkbenchToken_InstanceLoginView
			{

				private string viewName;

				private string defaultViewUrl;

				private string baseViewUrl;

				private string terminalViewUrl;

				private string fileTreeViewUrl;

				private string rdpViewUrl;

				public string ViewName
				{
					get
					{
						return viewName;
					}
					set	
					{
						viewName = value;
					}
				}

				public string DefaultViewUrl
				{
					get
					{
						return defaultViewUrl;
					}
					set	
					{
						defaultViewUrl = value;
					}
				}

				public string BaseViewUrl
				{
					get
					{
						return baseViewUrl;
					}
					set	
					{
						baseViewUrl = value;
					}
				}

				public string TerminalViewUrl
				{
					get
					{
						return terminalViewUrl;
					}
					set	
					{
						terminalViewUrl = value;
					}
				}

				public string FileTreeViewUrl
				{
					get
					{
						return fileTreeViewUrl;
					}
					set	
					{
						fileTreeViewUrl = value;
					}
				}

				public string RdpViewUrl
				{
					get
					{
						return rdpViewUrl;
					}
					set	
					{
						rdpViewUrl = value;
					}
				}
			}
		}
	}
}
