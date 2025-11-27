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

namespace Aliyun.Acs.sophonsoar.Model.V20220728
{
	public class DescribeLatestRecordSchemaResponse : AcsResponse
	{

		private string requestId;

		private DescribeLatestRecordSchema_PlaybookNodeSchema playbookNodeSchema;

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

		public DescribeLatestRecordSchema_PlaybookNodeSchema PlaybookNodeSchema
		{
			get
			{
				return playbookNodeSchema;
			}
			set	
			{
				playbookNodeSchema = value;
			}
		}

		public class DescribeLatestRecordSchema_PlaybookNodeSchema
		{

			private bool? isFinished;

			private List<DescribeLatestRecordSchema_NodeSchemaItem> nodeSchema;

			public bool? IsFinished
			{
				get
				{
					return isFinished;
				}
				set	
				{
					isFinished = value;
				}
			}

			public List<DescribeLatestRecordSchema_NodeSchemaItem> NodeSchema
			{
				get
				{
					return nodeSchema;
				}
				set	
				{
					nodeSchema = value;
				}
			}

			public class DescribeLatestRecordSchema_NodeSchemaItem
			{

				private string nodeName;

				private string componentName;

				private string actionName;

				private List<string> outputFields;

				public string NodeName
				{
					get
					{
						return nodeName;
					}
					set	
					{
						nodeName = value;
					}
				}

				public string ComponentName
				{
					get
					{
						return componentName;
					}
					set	
					{
						componentName = value;
					}
				}

				public string ActionName
				{
					get
					{
						return actionName;
					}
					set	
					{
						actionName = value;
					}
				}

				public List<string> OutputFields
				{
					get
					{
						return outputFields;
					}
					set	
					{
						outputFields = value;
					}
				}
			}
		}
	}
}
