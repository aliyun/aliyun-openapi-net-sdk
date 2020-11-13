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
	public class RecognizeExpressionResponse : AcsResponse
	{

		private string requestId;

		private RecognizeExpression_Data data;

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

		public RecognizeExpression_Data Data
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

		public class RecognizeExpression_Data
		{

			private List<RecognizeExpression_Element> elements;

			public List<RecognizeExpression_Element> Elements
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

			public class RecognizeExpression_Element
			{

				private string expression;

				private float? faceProbability;

				private RecognizeExpression_FaceRectangle faceRectangle;

				public string Expression
				{
					get
					{
						return expression;
					}
					set	
					{
						expression = value;
					}
				}

				public float? FaceProbability
				{
					get
					{
						return faceProbability;
					}
					set	
					{
						faceProbability = value;
					}
				}

				public RecognizeExpression_FaceRectangle FaceRectangle
				{
					get
					{
						return faceRectangle;
					}
					set	
					{
						faceRectangle = value;
					}
				}

				public class RecognizeExpression_FaceRectangle
				{

					private int? height;

					private int? left;

					private int? top;

					private int? width;

					public int? Height
					{
						get
						{
							return height;
						}
						set	
						{
							height = value;
						}
					}

					public int? Left
					{
						get
						{
							return left;
						}
						set	
						{
							left = value;
						}
					}

					public int? Top
					{
						get
						{
							return top;
						}
						set	
						{
							top = value;
						}
					}

					public int? Width
					{
						get
						{
							return width;
						}
						set	
						{
							width = value;
						}
					}
				}
			}
		}
	}
}
