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

namespace Aliyun.Acs.Ft.Model.V20180713
{
	public class BatchAuditTest01Response : AcsResponse
	{

		private string requestId;

		private string name;

		private BatchAuditTest01_Demo01 demo01;

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

		public BatchAuditTest01_Demo01 Demo01
		{
			get
			{
				return demo01;
			}
			set	
			{
				demo01 = value;
			}
		}

		public class BatchAuditTest01_Demo01
		{

			private List<BatchAuditTest01_Demo011Item> demo011;

			public List<BatchAuditTest01_Demo011Item> Demo011
			{
				get
				{
					return demo011;
				}
				set	
				{
					demo011 = value;
				}
			}

			public class BatchAuditTest01_Demo011Item
			{

				private string demo0111;

				public string Demo0111
				{
					get
					{
						return demo0111;
					}
					set	
					{
						demo0111 = value;
					}
				}
			}
		}
	}
}
