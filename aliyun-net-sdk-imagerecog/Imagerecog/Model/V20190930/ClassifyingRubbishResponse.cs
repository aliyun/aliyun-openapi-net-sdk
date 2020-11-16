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

namespace Aliyun.Acs.imagerecog.Model.V20190930
{
	public class ClassifyingRubbishResponse : AcsResponse
	{

		private string requestId;

		private ClassifyingRubbish_Data data;

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

		public ClassifyingRubbish_Data Data
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

		public class ClassifyingRubbish_Data
		{

			private bool? sensitive;

			private List<ClassifyingRubbish_Element> elements;

			public bool? Sensitive
			{
				get
				{
					return sensitive;
				}
				set	
				{
					sensitive = value;
				}
			}

			public List<ClassifyingRubbish_Element> Elements
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

			public class ClassifyingRubbish_Element
			{

				private string category;

				private float? categoryScore;

				private string rubbish;

				private float? rubbishScore;

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

				public float? CategoryScore
				{
					get
					{
						return categoryScore;
					}
					set	
					{
						categoryScore = value;
					}
				}

				public string Rubbish
				{
					get
					{
						return rubbish;
					}
					set	
					{
						rubbish = value;
					}
				}

				public float? RubbishScore
				{
					get
					{
						return rubbishScore;
					}
					set	
					{
						rubbishScore = value;
					}
				}
			}
		}
	}
}
