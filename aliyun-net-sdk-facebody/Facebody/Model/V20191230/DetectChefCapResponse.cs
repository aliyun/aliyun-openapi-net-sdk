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

namespace Aliyun.Acs.facebody.Model.V20191230
{
	public class DetectChefCapResponse : AcsResponse
	{

		private string requestId;

		private DetectChefCap_Data data;

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

		public DetectChefCap_Data Data
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

		public class DetectChefCap_Data
		{

			private List<DetectChefCap_ElementsItem> elements;

			public List<DetectChefCap_ElementsItem> Elements
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

			public class DetectChefCap_ElementsItem
			{

				private string category;

				private float? confidence;

				private List<string> box;

				public string Category
				{
					get
					{
						return category;
					}
					set	
					{
						category = value;
					}
				}

				public float? Confidence
				{
					get
					{
						return confidence;
					}
					set	
					{
						confidence = value;
					}
				}

				public List<string> Box
				{
					get
					{
						return box;
					}
					set	
					{
						box = value;
					}
				}
			}
		}
	}
}
