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
	public class DescribeEsExecuteDataResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeEsExecuteData_Content> contents;

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

		public List<DescribeEsExecuteData_Content> Contents
		{
			get
			{
				return contents;
			}
			set	
			{
				contents = value;
			}
		}

		public class DescribeEsExecuteData_Content
		{

			private string name;

			private List<string> columns;

			private List<string> points;

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public List<string> Columns
			{
				get
				{
					return columns;
				}
				set	
				{
					columns = value;
				}
			}

			public List<string> Points
			{
				get
				{
					return points;
				}
				set	
				{
					points = value;
				}
			}
		}
	}
}
