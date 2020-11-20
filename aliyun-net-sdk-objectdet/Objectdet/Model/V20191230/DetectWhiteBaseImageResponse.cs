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

namespace Aliyun.Acs.objectdet.Model.V20191230
{
	public class DetectWhiteBaseImageResponse : AcsResponse
	{

		private string requestId;

		private DetectWhiteBaseImage_Data data;

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

		public DetectWhiteBaseImage_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class DetectWhiteBaseImage_Data
		{

			private List<DetectWhiteBaseImage_Element> elements;

			public List<DetectWhiteBaseImage_Element> Elements
			{
				get
				{
					return elements;
				}
				set	
				{
					elements = value;
				}
			}

			public class DetectWhiteBaseImage_Element
			{

				private int? whiteBase;

				public int? WhiteBase
				{
					get
					{
						return whiteBase;
					}
					set	
					{
						whiteBase = value;
					}
				}
			}
		}
	}
}
